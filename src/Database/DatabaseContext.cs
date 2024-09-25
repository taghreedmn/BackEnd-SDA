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

        // This is very complex, I am starting to regret the complexity I made in our Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Persons").HasKey(p => p.PersonId);

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

            base.OnModelCreating(modelBuilder);
        }
    }
}
