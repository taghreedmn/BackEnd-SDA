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
        public DbSet<Store> Store { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Supply> Supply { get; set; }
        public DbSet<PersonIdCounter> PersonIdCounters { get; set; }
        public DbSet<GameConsole> Console { get; set; }
        public DbSet<GameStudio> Studio { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<VideoGameVersion> VideoGameVersion { get; set; }

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

            var payment1 = Guid.NewGuid();
            var payment2 = Guid.NewGuid();
            var payment3 = Guid.NewGuid();
            var payment4 = Guid.NewGuid();

            // Seed Payment data
            modelBuilder
                .Entity<Payment>()
                .HasData(
                    new Payment { Id = payment1, PaymentMethod = "Cash on delivery" },
                    new Payment { Id = payment2, PaymentMethod = "Visa" },
                    new Payment { Id = payment3, PaymentMethod = "Mada" },
                    new Payment { Id = payment4, PaymentMethod = "Apple Pay" }
                );

            // Seed Category data

            var category1 = Guid.NewGuid();
            var category2 = Guid.NewGuid();
            var category3 = Guid.NewGuid();
            modelBuilder
                .Entity<Category>()
                .HasData(
                    new Category { CategoryId = category1, CategoryName = "Category 1" },
                    new Category { CategoryId = category2, CategoryName = "Category 2" },
                    new Category { CategoryId = category3, CategoryName = "Category 3" }
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

            // Seed Store data
            var Store1Id = Guid.NewGuid();
            var Store2Id = Guid.NewGuid();
            modelBuilder
                .Entity<Store>()
                .HasData(
                    new Store
                    {
                        StoreId = Store1Id,
                        NumberOfEmployee = 5,
                        WorkHours = 40,
                        Location = "Location 1",
                    },
                    new Store
                    {
                        StoreId = Store2Id,
                        NumberOfEmployee = 8,
                        WorkHours = 35,
                        Location = "Location 2",
                    }
                );

            // Console data
            var GameConsoleId1 = Guid.NewGuid();
            var GameConsoleId2 = Guid.NewGuid();
            var GameConsoleId3 = Guid.NewGuid();

            modelBuilder
                .Entity<GameConsole>()
                .HasData(
                    new GameConsole { GameConsoleId = GameConsoleId1, ConsoleName = "Console 1" }
                );
            modelBuilder
                .Entity<GameConsole>()
                .HasData(
                    new GameConsole { GameConsoleId = GameConsoleId2, ConsoleName = "Console 2" }
                );
            modelBuilder
                .Entity<GameConsole>()
                .HasData(
                    new GameConsole { GameConsoleId = GameConsoleId3, ConsoleName = "Console 3" }
                );
            // Studio data
            var GameStudio1Id = Guid.NewGuid();
            modelBuilder
                .Entity<GameStudio>()
                .HasData(
                    new GameStudio
                    {
                        GameStudioId = GameStudio1Id,
                        StudioName = "Studio 1",
                        StudioPicturePath = "pic1/png",
                    }
                );

            // Seed Publisher data
            var Publisher1Id = Guid.NewGuid();
            var Publisher2Id = Guid.NewGuid();
            modelBuilder
                .Entity<Publisher>()
                .HasData(
                    new Publisher
                    {
                        PublisherId = Publisher1Id,
                        PublisherName = "Publisher 1",
                        PublisherEmail = "publisher1@example.com",
                        PublisherPicturePath = "",
                    },
                    new Publisher
                    {
                        PublisherId = Publisher2Id,
                        PublisherName = "Publisher 2",
                        PublisherEmail = "publisher2@example.com",
                        PublisherPicturePath = "",
                    }
                );

            // Seed VideoGameInfo data
            var VideoGameInfoId1 = Guid.NewGuid();
            var VideoGameInfoId2 = Guid.NewGuid();

            modelBuilder
                .Entity<VideoGameInfo>()
                .HasData(
                    new VideoGameInfo
                    {
                        VideoGameInfoId = VideoGameInfoId1,
                        GameName = "Game 1",
                        Description = "Description for Game 1",
                        YearOfRelease = "2019-07-04",
                        TotalRating = 3,
                        PublisherId = Publisher1Id,
                    },
                    new VideoGameInfo
                    {
                        VideoGameInfoId = VideoGameInfoId2,
                        GameName = "Game 2",
                        Description = "Description for Game 2",
                        YearOfRelease = "2023-04-08",
                        TotalRating = 5,
                        PublisherId = Publisher2Id,
                    }
                );

            var VideoGameVersionId1 = Guid.NewGuid();
            var VideoGameVersionId2 = Guid.NewGuid();
            //seed VideoGameVersion data
            modelBuilder
                .Entity<VideoGameVersion>()
                .HasData(
                    new VideoGameVersion
                    {
                        VideoGameVersionId = VideoGameVersionId1,
                        Price = 200,
                        ConsoleId = GameConsoleId1,
                        VideoGameInfoId = VideoGameInfoId1,
                    },
                    new VideoGameVersion
                    {
                        VideoGameVersionId = VideoGameVersionId2,
                        Price = 200,
                        ConsoleId = GameConsoleId2,
                        VideoGameInfoId = VideoGameInfoId1,
                    }
                );

            var inventory1Id = Guid.NewGuid();
            var inventory2Id = Guid.NewGuid();

            // Seed Inventory data
            modelBuilder
                .Entity<Inventory>()
                .HasData(
                    new Inventory
                    {
                        InventoryId = inventory1Id,
                        VideoGameVersionId = VideoGameVersionId1,
                        StoreId = Store1Id,
                        InventoryQuantity = 50,
                    },
                    new Inventory
                    {
                        InventoryId = inventory2Id,
                        VideoGameVersionId = VideoGameVersionId2,
                        StoreId = Store2Id,
                        InventoryQuantity = 100,
                    }
                );

            // Seed Supply data
            var Supply1Id = Guid.NewGuid();
            var Supply2Id = Guid.NewGuid();
            modelBuilder
                .Entity<Supply>()
                .HasData(
                    new Supply
                    {
                        SupplyId = Supply1Id,
                        SupplierId = supplier1Id,
                        VideoGameVersionId = VideoGameVersionId1,
                        SupplyQuantity = 100,
                        SupplierDate = DateTime.UtcNow,
                        InventoryId = inventory2Id,
                    },
                    new Supply
                    {
                        SupplyId = Supply2Id,
                        SupplierId = supplier2Id,
                        VideoGameVersionId = VideoGameVersionId2,
                        SupplyQuantity = 50,
                        SupplierDate = DateTime.UtcNow.AddDays(-1),
                        InventoryId = inventory1Id,
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
