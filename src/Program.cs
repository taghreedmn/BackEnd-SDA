using FusionTech.Service.CustomerService;
using FusionTech.Service.PersonService;
using FusionTech.src.Config;
using FusionTech.src.Database;
using FusionTech.src.Repository;

using FusionTech.src.Services;
using FusionTech.src.Services.category;
using FusionTech.src.Services.payment;

using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using sda_3_online_Backend_Teamwork.src.Repository;
using sda_3_online_Backend_Teamwork.src.Service;
using sda_3_online_Backend_Teamwork.src.Service.Console;
using sda_3_online_Backend_Teamwork.src.Service.Studio;

var builder = WebApplication.CreateBuilder(args);

//connect the database
var dataSourceBuilder = new NpgsqlDataSourceBuilder(
    builder.Configuration.GetConnectionString("local")
);
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(dataSourceBuilder.Build());
});



builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

// add DI services
builder
    .Services.AddScoped<IPersonService, PersonService>()
    .AddScoped<PersonRepository, PersonRepository>();

builder
    .Services.AddScoped<ICustomerService, CustomerService>()
    .AddScoped<CustomerRepository, CustomerRepository>();


builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddScoped<ICategoryService, CategoryService>().AddScoped<CategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPaymentService, PaymentService>().AddScoped<PaymentRepository, PaymentRepository>();

//add auto mapper
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);
builder
    .Services.AddScoped<IConsoleService, ConsoleService>()
    .AddScoped<ConsoleRepository, ConsoleRepository>();

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);
builder
    .Services.AddScoped<IStudioService, StudioService>()
    .AddScoped<StudioRepository, StudioRepository>();

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
app.UseAuthorization();

// Map the controllers
app.MapControllers();

app.Run();
