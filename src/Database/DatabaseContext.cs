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
        public DbSet<OrderedGames> OrderedGames { get; set; }
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

            var SystemAdmin1 = new SystemAdmin
            {
                PersonId = -1,
                PersonEmail = "admin@mail.com",
                PersonName = "Super Admin",
                PersonPassword = hashedPassword,
                PersonPhoneNumber = "+966500000000",
                salt = salt,
                ManageGames = true,
                ManageCustomers = true,
                ManageEmployees = true,
                ManageStores = true,
                ManageSystemAdmins = true,
            };

            // Seed Category data
            var Category1 = new Category { CategoryId = Guid.NewGuid(), CategoryName = "Sports" };
            var Category2 = new Category
            {
                CategoryId = Guid.NewGuid(),
                CategoryName = "Adventure",
            };
            var Category3 = new Category
            {
                CategoryId = Guid.NewGuid(),
                CategoryName = "Simulation",
            };

            // Seed GameConsole data
            var Console1 = new GameConsole
            {
                GameConsoleId = Guid.NewGuid(),
                ConsoleName = "GamerBox",
            };
            var Console2 = new GameConsole
            {
                GameConsoleId = Guid.NewGuid(),
                ConsoleName = "FusionPlay",
            };
            var Console3 = new GameConsole
            {
                GameConsoleId = Guid.NewGuid(),
                ConsoleName = "RetroCube",
            };

            // Seed GameStudio data
            var Studio1 = new GameStudio
            {
                GameStudioId = Guid.NewGuid(),
                StudioName = "FromSoftware",
                StudioPicturePath = "pic1/png",
            };
            var Studio2 = new GameStudio
            {
                GameStudioId = Guid.NewGuid(),
                StudioName = "Treyarch",
                StudioPicturePath = "pic2/png",
            };
            var Studio3 = new GameStudio
            {
                GameStudioId = Guid.NewGuid(),
                StudioName = "Valve",
                StudioPicturePath = "pic3/png",
            };

            var Publisher1 = new Publisher
            {
                PublisherId = Guid.NewGuid(),
                PublisherName = "Activision",
                PublisherEmail = "publisher1@example.com",
                PublisherPicturePath = "",
            };
            var Publisher2 = new Publisher
            {
                PublisherId = Guid.NewGuid(),
                PublisherName = "Microsoft",
                PublisherEmail = "publisher2@example.com",
                PublisherPicturePath = "",
            };

            var VideoGameInfo1 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Dark souls",
                Description = "Description for Game 1",
                YearOfRelease = "2019-09-08",
                TotalRating = 3,
                PublisherId = Publisher1.PublisherId,
                GamePicturePath = "",
            };
            var VideoGameInfo2 = new VideoGameInfo
            {
                VideoGameInfoId = Guid.NewGuid(),
                GameName = "Fifa",
                Description = "Description for Game 2",
                YearOfRelease = "2023-07-04",
                TotalRating = 5,
                PublisherId = Publisher2.PublisherId,
                GamePicturePath = "",
            };

            var VideoGameVersion1 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 80,
                VideoGameInfoId = VideoGameInfo1.VideoGameInfoId,
                GameConsoleId = Console1.GameConsoleId,
            };
            var VideoGameVersion2 = new VideoGameVersion
            {
                VideoGameVersionId = Guid.NewGuid(),
                Price = 85,
                VideoGameInfoId = VideoGameInfo2.VideoGameInfoId,
                GameConsoleId = Console2.GameConsoleId,
            };

            var Store1 = new Store
            {
                StoreId = Guid.NewGuid(),
                WorkHours = 35,
                Location = "Riyadh",
            };
            var Store2 = new Store
            {
                StoreId = Guid.NewGuid(),
                WorkHours = 40,
                Location = "Jeddah",
            };

            var Inventory1 = new Inventory
            {
                InventoryId = Guid.NewGuid(),
                VideoGameVersionId = VideoGameVersion1.VideoGameVersionId,
                StoreId = Store1.StoreId,
                GameQuantity = 250,
            };
            var Inventory2 = new Inventory
            {
                InventoryId = Guid.NewGuid(),
                VideoGameVersionId = VideoGameVersion2.VideoGameVersionId,
                StoreId = Store2.StoreId,
                GameQuantity = 400,
            };

            // Seed Payment data
            var Payment1 = new Payment
            {
                PaymentId = Guid.NewGuid(),
                PaymentMethod = "Cash on delivery",
            };
            var Payment2 = new Payment { PaymentId = Guid.NewGuid(), PaymentMethod = "Visa" };
            var Payment3 = new Payment { PaymentId = Guid.NewGuid(), PaymentMethod = "Mada" };
            var Payment4 = new Payment { PaymentId = Guid.NewGuid(), PaymentMethod = "Apple Pay" };

            // Seed PersonIdCounter data
            var PersonIdCounter1 = new PersonIdCounter
            {
                PersonIdCounterId = PersonType.SystemAdmin,
                CurrentId = 0,
            };
            var PersonIdCounter2 = new PersonIdCounter
            {
                PersonIdCounterId = PersonType.StoreEmployee,
                CurrentId = 0,
            };
            var PersonIdCounter3 = new PersonIdCounter
            {
                PersonIdCounterId = PersonType.Customer,
                CurrentId = 0,
            };

            // Seed Supplier data
            var Supplier1 = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Tech Supplies Co",
                SupplierContactInfo = "contact@techsupplies.com, +966-800-555-0199",
                SupplierBankInfo = "Account No: 123456789",
            };
            var Supplier2 = new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Gaming Goods Ltd",
                SupplierContactInfo = "support@gaminggoods.com, +966-800-555-0198",
                SupplierBankInfo = "Account No: 987654321",
            };

            var Supply1 = new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Supplier1.SupplierId,
                VideoGameVersionId = VideoGameVersion1.VideoGameVersionId,
                SupplyQuantity = 100,
                SupplierDate = DateTime.UtcNow,
                InventoryId = Inventory1.InventoryId,
            };
            var Supply2 = new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Supplier2.SupplierId,
                VideoGameVersionId = VideoGameVersion2.VideoGameVersionId,
                SupplyQuantity = 50,
                SupplierDate = DateTime.UtcNow.AddDays(-1),
                InventoryId = Inventory2.InventoryId,
            };

            // Seed Publisher data










            // Seed Inventory data


            // Seed Supply data

            // modelBuilder
            modelBuilder.Entity<SystemAdmin>().HasData(SystemAdmin1);

            modelBuilder.Entity<Category>().HasData(Category1, Category2, Category3);

            modelBuilder.Entity<GameConsole>().HasData(Console1, Console2, Console3);

            modelBuilder.Entity<GameStudio>().HasData(Studio1, Studio2, Studio3);

            modelBuilder.Entity<Publisher>().HasData(Publisher1, Publisher2);

            modelBuilder.Entity<VideoGameInfo>().HasData(VideoGameInfo1, VideoGameInfo2);

            modelBuilder.Entity<VideoGameVersion>().HasData(VideoGameVersion1, VideoGameVersion2);

            modelBuilder.Entity<Store>().HasData(Store1, Store2);

            modelBuilder.Entity<Inventory>().HasData(Inventory1, Inventory2);

            modelBuilder.Entity<Payment>().HasData(Payment1, Payment2, Payment3, Payment4);

            modelBuilder
                .Entity<PersonIdCounter>()
                .HasData(PersonIdCounter1, PersonIdCounter2, PersonIdCounter3);

            modelBuilder.Entity<Supplier>().HasData(Supplier1, Supplier2);

            modelBuilder.Entity<Supply>().HasData(Supply1, Supply2);
        }
    }
}
