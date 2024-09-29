using System;
using FusionTech.src.Entity;
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
        // Config
        public DbSet<PersonIdCounter> PersonIdCounters { get; set; 
        public DbSet<GameConsole> Console { get; set; }
        public DbSet<GameStudio> Studio { get; set; }

        public DatabaseContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                    new Supply
                    {
                        SupplyId = Guid.NewGuid(),
                        SupplierId = supplier1Id,
                        GamesId = Guid.NewGuid(),
                        SupplierQuantity = 100,
                        SupplierDate = DateTime.UtcNow,
                        InventoryId = Guid.NewGuid(),
                    },
                    new Supply
                    {
                        SupplyId = Guid.NewGuid(),
                        SupplierId = supplier2Id,
                        GamesId = Guid.NewGuid(),
                        SupplierQuantity = 50,
                        SupplierDate = DateTime.UtcNow,
                        InventoryId = Guid.NewGuid(),
                    }
                );

            // Person table: PersonId as Primary Key
            modelBuilder.Entity<Person>().ToTable("Persons").HasKey(p => p.PersonId);

            //Customer table
            modelBuilder.Entity<Customer>().ToTable("Customers").HasKey(c => c.PersonId); // Set primary key
            //Has relationship with table Person
            modelBuilder
                .Entity<Customer>()
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<Customer>(c => c.PersonId); // Set foreign key

            // // StoreEmployee table
            modelBuilder
                .Entity<StoreEmployee>()
                .ToTable("StoreEmployees")
                .HasKey(se => se.PersonId); // Set primary key
            modelBuilder
                .Entity<StoreEmployee>()
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<StoreEmployee>(se => se.PersonId); // Set foreign key

            // // SystemAdmin entity configuration
            modelBuilder.Entity<SystemAdmin>().ToTable("SystemAdmins").HasKey(sa => sa.PersonId); // Set primary key
            modelBuilder
                .Entity<SystemAdmin>()
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<SystemAdmin>(sa => sa.PersonId); // Set foreign key

             base.OnModelCreating(modelBuilder);

            // Console data

            modelBuilder
                .Entity<GameConsole>()
                .HasData(new GameConsole { ConsoleId = Guid.NewGuid(), ConsoleName = "Console 1" });
            modelBuilder
                .Entity<GameConsole>()
                .HasData(new GameConsole { ConsoleId = Guid.NewGuid(), ConsoleName = "Console 2" });
            modelBuilder
                .Entity<GameConsole>()
                .HasData(new GameConsole { ConsoleId = Guid.NewGuid(), ConsoleName = "Console 3" });
            // Studio data
            modelBuilder
                .Entity<GameStudio>()
                .HasData(new GameStudio { StudioId = Guid.NewGuid(), StudioName = "Studio 1" });
            modelBuilder
                .Entity<GameStudio>()
                .HasData(new GameStudio { StudioId = Guid.NewGuid(), StudioName = "Studio 2" });
            modelBuilder
              .Entity<GameStudio>()
                .HasData(new GameStudio { StudioId = Guid.NewGuid(), StudioName = "Studio 3" });
        
           
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
