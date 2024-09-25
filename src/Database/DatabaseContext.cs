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

        public DatabaseContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Person table: PersonId as Primary Key
            modelBuilder.Entity<Person>().ToTable("Persons").HasKey(p => p.PersonId);

            // Customer table
            modelBuilder.Entity<Customer>().ToTable("Customers").HasKey(c => c.PersonId); // Set primary key
            // Has relationship with table Person
            modelBuilder
                .Entity<Customer>()
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<Customer>(c => c.PersonId); // Set foreign key

            // StoreEmployee table
            modelBuilder
                .Entity<StoreEmployee>()
                .ToTable("StoreEmployees")
                .HasKey(se => se.PersonId); // Set primary key
            modelBuilder
                .Entity<StoreEmployee>()
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<StoreEmployee>(se => se.PersonId); // Set foreign key

            // SystemAdmin entity configuration
            modelBuilder.Entity<SystemAdmin>().ToTable("SystemAdmins").HasKey(sa => sa.PersonId); // Set primary key
            modelBuilder
                .Entity<SystemAdmin>()
                .HasOne<Person>()
                .WithOne()
                .HasForeignKey<SystemAdmin>(sa => sa.PersonId); // Set foreign key

            base.OnModelCreating(modelBuilder);
        }
    }
}
