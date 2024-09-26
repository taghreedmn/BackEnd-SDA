using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using backend.src.Entity;
using backend.src.Database;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //connect database
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(builder.Configuration.GetConnectionString("Local"));

        builder.Services.AddDbContext<DatabaseContxt>(option =>
        {
            option.UseNpgsql(dataSourceBuilder.Build());
        }
        );// Add services to the container
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        // test if database is connected or not
        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContxt>();
            try
            {
                // Check if the application can connect to the database
                if (dbContext.Database.CanConnect())
                {
                    Console.WriteLine("Database is connected");
                }
                else
                {
                    Console.WriteLine("Unable to connect to the database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database connection failed: {ex.Message}");
}
        }
        // Enable Swagger for API documentation
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Map the controllers
        app.MapControllers();
        // Configure the HTTP request pipeline
        app.UseHttpsRedirection();
        app.UseAuthorization();



        app.Run();
    }
}