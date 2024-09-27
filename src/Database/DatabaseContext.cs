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

        // Config
        public DbSet<PersonIdCounter> PersonIdCounters { get; set; }

        public DatabaseContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*** Person and its children ***/
            // I need to define Person as a base table
            modelBuilder.Entity<Person>().ToTable("Persons").HasKey(p => p.PersonId);

            // No auto-generation
            modelBuilder.Entity<Person>().Property(p => p.PersonId).ValueGeneratedNever();

            modelBuilder
                .Entity<Customer>()
                .ToTable("Customers")
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<Customer>(c => c.PersonId);

            modelBuilder
                .Entity<StoreEmployee>()
                .ToTable("StoreEmployees")
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<StoreEmployee>(se => se.PersonId);

            modelBuilder
                .Entity<SystemAdmin>()
                .ToTable("SystemAdmins")
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<SystemAdmin>(sa => sa.PersonId);

            // Store enums as string
            modelBuilder
                .Entity<PersonIdCounter>()
                .Property(p => p.PersonIdCounterId)
                .HasConversion<string>();

            base.OnModelCreating(modelBuilder);

            // Code to seed data
            // Payment Data
            modelBuilder
                .Entity<Payment>()
                .HasData(new Payment { Id = Guid.NewGuid(), PaymentMethod = "Cash on deleviry" });
            modelBuilder
                .Entity<Payment>()
                .HasData(new Payment { Id = Guid.NewGuid(), PaymentMethod = "Visa" });
            modelBuilder
                .Entity<Payment>()
                .HasData(new Payment { Id = Guid.NewGuid(), PaymentMethod = "Mada" });
            modelBuilder
                .Entity<Payment>()
                .HasData(new Payment { Id = Guid.NewGuid(), PaymentMethod = "Apple Pay" });
            // Category data
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 1" });
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 2" });
            modelBuilder
                .Entity<Category>()
                .HasData(new Category { Id = Guid.NewGuid(), CategoryName = "Category 3" });
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
