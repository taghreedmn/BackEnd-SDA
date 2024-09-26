   //Override OnModelCreating method to seed Category and Payment data.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Code to seed data
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = Guid.NewGuid(), PaymentMethod = "Cash on deleviry" });
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = Guid.NewGuid(), PaymentMethod = "Visa" });
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = Guid.NewGuid(), PaymentMethod = "Mada" });
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = Guid.NewGuid(), PaymentMethod = "Apple Pay" });
            // Category data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), CategoryName = "Category 1" });
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = Guid.NewGuid(), CategoryName = "Category 2" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), CategoryName = "Category 3" });
        }
    }
}