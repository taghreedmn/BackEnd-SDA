using FusionTech.Middlewares;
using FusionTech.src.Database;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Services.category;
using FusionTech.src.Services.Console;
using FusionTech.src.Services.Customer;
using FusionTech.src.Services.order;
using FusionTech.src.Services.Payment;
using FusionTech.src.Services.Person;
using FusionTech.src.Services.Studio;
using FusionTech.src.Services.supply;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore;
using Npgsql;





var builder = WebApplication.CreateBuilder(args);

//connect the database
var dataSourceBuilder = new NpgsqlDataSourceBuilder(
    builder.Configuration.GetConnectionString("local")
);
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

builder.Services.AddAutoMapper(typeof(MapperProfile));
builder
    .Services.AddScoped<ICategoryService, CategoryService>()
    .AddScoped<CategoryRepository, CategoryRepository>();
builder
    .Services.AddScoped<IPaymentService, PaymentService>()
    .AddScoped<PaymentRepository, PaymentRepository>();
builder
.Services.AddScoped<IOrderService, OrderService>()
.AddScoped<OrderRepository, OrderRepository>();

// builder
// .Services.AddScoped<IInventoryService, InventoryService>()
// .AddScoped<InventoryRepository, InventoryRepository>();

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
app.UseMiddleware<LoggingMiddleware>();

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
