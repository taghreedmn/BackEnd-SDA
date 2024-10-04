using FusionTech.src.Entity;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreEmployee> StoreEmployees { get; set; }
        public DbSet<SystemAdmin> SystemAdmins { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Supply> Supply { get; set; }
        public DbSet<PersonIdCounter> PersonIdCounters { get; set; }
        public DbSet<GameConsole> Console { get; set; }
        public DbSet<GameStudio> Studio { get; set; }

        public DbSet<Inventory> Inventory { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        public DbSet<Store> Store { get; set; }

        public DbSet<VideoGameInfo> VideoGameInfo { get; set; }


        public DatabaseContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.HasPostgresEnum<PersonType>();

            base.OnModelCreating(modelBuilder);

            // Seed Super Admin
            // this is an extremly sensitive information, it should be removed in a real world scenario.
            PasswordUtils.HashPassword("SuperAdmin", out string hashedPassword, out byte[] salt);
            modelBuilder
                .Entity<SystemAdmin>()
                .HasData(
                    new SystemAdmin
                    {
                        PersonId = -1,
                        PersonEmail = "admin@mail.com",
                        PersonName = "Super Admin",
                        PersonPassword = hashedPassword,
                        PersonPhone = "+966500000000",
                        ProfilePicturePath = "",
                        salt = salt,
                        ManageGames = true,
                        ManageCustomers = true,
                        ManageEmployees = true,
                        ManageStores = true,
                        ManageSystemAdmins = true,
                    }
                );

            // Seed Payment data
            modelBuilder
                .Entity<Payment>()
                .HasData(
                    new Payment { Id = Guid.NewGuid(), PaymentMethod = "Cash on delivery" },
                    new Payment { Id = Guid.NewGuid(), PaymentMethod = "Visa" },
                    new Payment { Id = Guid.NewGuid(), PaymentMethod = "Mada" },
                    new Payment { Id = Guid.NewGuid(), PaymentMethod = "Apple Pay" }
                );

            // Seed Category data
            modelBuilder
                .Entity<Category>()
                .HasData(
                    new Category { Id = Guid.NewGuid(), CategoryName = "Category 1" },
                    new Category { Id = Guid.NewGuid(), CategoryName = "Category 2" },
                    new Category { Id = Guid.NewGuid(), CategoryName = "Category 3" }
                );

            // Seed Supplier data
            var supplier1Id = Guid.NewGuid();
            var supplier2Id = Guid.NewGuid();

            modelBuilder
                .Entity<Supplier>()
                .HasData(
                    new Supplier
                    {
                        SupplierId = supplier1Id,
                        SupplierName = "Supplier 1",
                        SupplierContact = "Contact 1",
                        SupplierBankInfo = "Bank Info 1",
                    },
                    new Supplier
                    {
                        SupplierId = supplier2Id,
                        SupplierName = "Supplier 2",
                        SupplierContact = "Contact 2",
                        SupplierBankInfo = "Bank Info 2",
                    }
                );

            // Seed Supply data
            modelBuilder
                .Entity<Supply>()
                .HasData(
                    new Supply { SupplyId = Guid.NewGuid(), SupplierId = supplier1Id, GamesId = Guid.NewGuid(), SupplierQuantity = 100, SupplierDate = DateTime.UtcNow, InventoryId = Guid.NewGuid(), },
                    new Supply { SupplyId = Guid.NewGuid(), SupplierId = supplier2Id, GamesId = Guid.NewGuid(), SupplierQuantity = 50, SupplierDate = DateTime.UtcNow, InventoryId = Guid.NewGuid(), }
                    );

            // Seed Publisher data
            modelBuilder
           .Entity<Publisher>()
           .HasData(
               new Publisher { PublisherId = Guid.NewGuid(), PublisherName = "Publisher 1", Email = "publisher1@example.com", PublisherPicturePath = "" },
               new Publisher { PublisherId = Guid.NewGuid(), PublisherName = "Publisher 2", Email = "publisher2@example.com", PublisherPicturePath = "" }
           );

            // Seed Inventory data
            var inventory1Id = Guid.NewGuid();
            var inventory2Id = Guid.NewGuid();

            modelBuilder
                .Entity<Inventory>()
                .HasData(
                    new Inventory
                    {
                        InventoryId = inventory1Id,
                        GameId = Guid.NewGuid(),
                        StoreId = Guid.NewGuid(),
                        InventoryQuantity = 50
                    },
                    new Inventory
                    {
                        InventoryId = inventory2Id,
                        GameId = Guid.NewGuid(),
                        StoreId = Guid.NewGuid(),
                        InventoryQuantity = 100,
                    }
                );

            // Seed Store data
            var employeeId1 = Guid.NewGuid();
            var employeeId2 = Guid.NewGuid();

            modelBuilder
                .Entity<Store>()
    .HasData(
                    new Store
                    {
                        StoreId = Guid.NewGuid(),
                        InventoryId = inventory1Id,
                        NumberOfEmployee = 5,
                        WorkHours = 40,
                        EmployeeId = employeeId1,
                        Location = "Location 1"
                    },
                    new Store
                    {
                        StoreId = Guid.NewGuid(),
                        InventoryId = inventory2Id,
                        NumberOfEmployee = 8,
                        WorkHours = 35,
                        EmployeeId = employeeId2,
                        Location = "Location 2"
                    }
                );
            modelBuilder.Entity<VideoGameInfo>()
                   .HasKey(vg => vg.GameId);

            // Seed VideoGameInfo data
            var videoGame1Id = Guid.NewGuid();
            var videoGame2Id = Guid.NewGuid();


            modelBuilder
                .Entity<VideoGameInfo>()
                .HasData(
                    new VideoGameInfo
                    {
                        GameId = videoGame1Id,
                        GameName = "Game 1",

                        Description = "Description for Game 1",
                        YearOfRelease = "2019-07-04",
                        TotalRating = 3,
                        PublisherId = Guid.NewGuid()
                    },
                    new VideoGameInfo
                    {
                        GameId = videoGame2Id,
                        GameName = "Game 2",

                        Description = "Description for Game 2",
                        YearOfRelease = "2023-04-08",
                        TotalRating = 5,
                        PublisherId = Guid.NewGuid()
                    }
                );
            // Console data

            modelBuilder
                .Entity<GameConsole>()
                .HasData(
                    new GameConsole { GameConsoleId = Guid.NewGuid(), ConsoleName = "Console 1" }
                );
            modelBuilder
                .Entity<GameConsole>()
                .HasData(
                    new GameConsole { GameConsoleId = Guid.NewGuid(), ConsoleName = "Console 2" }
                );
            modelBuilder
                .Entity<GameConsole>()
                .HasData(
                    new GameConsole { GameConsoleId = Guid.NewGuid(), ConsoleName = "Console 3" }
                );
            // Studio data
            modelBuilder
                .Entity<GameStudio>()
                .HasData(
                    new GameStudio
                    {
                        GameStudioId = Guid.NewGuid(),
                        StudioName = "Studio 1",
                        StudioPicturePath = "pic1/png",
                    }
                );
            modelBuilder
                .Entity<Payment>()
                .HasData(new Payment { Id = Guid.NewGuid(), PaymentMethod = "Master Card" });
            modelBuilder
                .Entity<Payment>()
                .HasData(new Payment { Id = Guid.NewGuid(), PaymentMethod = "Using points" });
            // Category data
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 4" });
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 5" });
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 6" });
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 7" });
            modelBuilder
                .Entity<GameStudio>()
                .HasData(
                    new GameStudio
                    {
                        GameStudioId = Guid.NewGuid(),
                        StudioName = "Studio 2",
                        StudioPicturePath = "pic2/png",
                    }
                );
            modelBuilder
                .Entity<GameStudio>()
                .HasData(
                    new GameStudio
                    {
                        GameStudioId = Guid.NewGuid(),
                        StudioName = "Studio 3",
                        StudioPicturePath = "pic3/png",
                    }
                );

            // Id Generation counter Data
            modelBuilder
                .Entity<PersonIdCounter>()
                .HasData(
                    new PersonIdCounter
                    {
                        PersonIdCounterId = PersonType.SystemAdmin,
                        CurrentId = 0,
                    }
                );
            modelBuilder
                .Entity<PersonIdCounter>()
                .HasData(
                    new PersonIdCounter
                    {
                        PersonIdCounterId = PersonType.StoreEmployee,
                        CurrentId = 0,
                    }
                );
            modelBuilder
                .Entity<PersonIdCounter>()
                .HasData(
                    new PersonIdCounter { PersonIdCounterId = PersonType.Customer, CurrentId = 0 }
                );
        }
    }
}
