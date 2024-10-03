using System.Text;
using FusionTech.src.Database;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Service.Store;
using FusionTech.src.Services.Category;
using FusionTech.src.Services.Console;
using FusionTech.src.Services.Customer;
using FusionTech.src.Services.Inventory;
using FusionTech.src.Services.Payment;
using FusionTech.src.Services.Person;
using FusionTech.src.Services.StoreEmployee;
using FusionTech.src.Services.Studio;
using FusionTech.src.Services.supply;
using FusionTech.src.Services.SystemAdmin;
using FusionTech.src.Services.VideoGamesInfo;
using FusionTech.src.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

//connect the database
var dataSourceBuilder = new NpgsqlDataSourceBuilder(
    builder.Configuration.GetConnectionString("local")
);

// I might remove this, as I don't see the need nor if I acutally have PersonType in our Databas
// future me, if you decide to remove it, don't forgot to remove it in TokenUtils.cs too
dataSourceBuilder.MapEnum<PersonType>();
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(dataSourceBuilder.Build());
});

builder.Services.AddAutoMapper(typeof(MapperProfile));
builder
    .Services.AddScoped<ISupplyService, SupplyService>()
    .AddScoped<SupplyRepository, SupplyRepository>();

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

// add DI services
builder
    .Services.AddScoped<IPersonService, PersonService>()
    .AddScoped<PersonRepository, PersonRepository>();

builder
    .Services.AddScoped<ICustomerService, CustomerService>()
    .AddScoped<CustomerRepository, CustomerRepository>();

builder
    .Services.AddScoped<IStoreEmployeeService, StoreEmployeeService>()
    .AddScoped<StoreEmployeeRepository, StoreEmployeeRepository>();

builder
    .Services.AddScoped<ISystemAdminService, SystemAdminService>()
    .AddScoped<SystemAdminRepository, SystemAdminRepository>();

builder.Services.AddAutoMapper(typeof(MapperProfile));
builder
    .Services.AddScoped<ICategoryService, CategoryService>()
    .AddScoped<CategoryRepository, CategoryRepository>();
builder
    .Services.AddScoped<IPaymentService, PaymentService>()
    .AddScoped<PaymentRepository, PaymentRepository>();
builder
    .Services.AddScoped<IInventoryService, InventoryService>()
    .AddScoped<InventoryRepository, InventoryRepository>();
builder
    .Services.AddScoped<IStoreService, StoreService>()
    .AddScoped<StoreRepository, StoreRepository>();
builder
    .Services.AddScoped<IVideoGameInfoService, VideoGameInfoService>()
    .AddScoped<VideoGameInfoRepository, VideoGameInfoRepository>();

//add auto mapper
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);
builder
    .Services.AddScoped<IConsoleService, ConsoleService>()
    .AddScoped<ConsoleRepository, ConsoleRepository>();

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);
builder
    .Services.AddScoped<IStudioService, StudioService>()
    .AddScoped<StudioRepository, StudioRepository>();

builder
    .Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:Key").Value!)
            ),
        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.RequireRole(PersonType.SystemAdmin.ToString()));
    options.AddPolicy("Employee", policy => policy.RequireRole(PersonType.SystemAdmin.ToString()));
    options.AddPolicy("Customer", policy => policy.RequireRole(PersonType.Customer.ToString()));
    options.AddPolicy(
        "EmployeeOrAdmin",
        policy =>
            policy.RequireRole(
                PersonType.SystemAdmin.ToString(),
                PersonType.StoreEmployee.ToString()
            )
    );
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//test if the database is conncted
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    try
    {
        if (dbContext.Database.CanConnect())
        {
            Console.WriteLine("Database is connected.");
        }
        else
        {
            Console.WriteLine("Unable to connect to the database.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Databse connection failed:{ex.Message}");
    }
}

// Enable Swagger for API documentation
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

// Map the controllers
app.MapControllers();

app.Run();
