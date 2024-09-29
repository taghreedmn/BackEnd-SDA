using FusionTech.src.Database;
using FusionTech.src.utils;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using FusionTech.src.Services.supply;
using FusionTech.src.Repository;
using FusionTech.src.Services;




var builder = WebApplication.CreateBuilder(args);

//connect the database
var dataSourceBuilder = new NpgsqlDataSourceBuilder(
    builder.Configuration.GetConnectionString("local")
);
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(dataSourceBuilder.Build());
});
// add auto_mapper
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);


builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddScoped<ISupplyService, SupplyService>().AddScoped<SupplyRepository, SupplyRepository>();
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
