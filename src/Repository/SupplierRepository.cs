using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class SupplierRepository
    {
        // DbSet for accessing Supplier entities in the database
        protected DbSet<Supplier> _supplier;

        // Database context for interacting with the database
        protected DatabaseContext _databaseContext;

        // Constructor that initializes the repository with a DatabaseContext
        public SupplierRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

            // Initialize the _supplier DbSet for the Supplier entity
            _supplier = databaseContext.Set<Supplier>();
        }

        // Asynchronously create a new Supplier and save it to the database
        public async Task<Supplier> CreateOneAsync(Supplier newSupplier)
        {
            // Add the new supplier to the DbSet
            await _supplier.AddAsync(newSupplier);
            // Save changes to the database
            await _databaseContext.SaveChangesAsync();
            return newSupplier; // Return the created supplier
        }

        // Asynchronously retrieve a Supplier by its ID
        public async Task<Supplier?> GetByIdAsync(int Id)
        {
            // Find and return the supplier by ID
            return await _supplier.FindAsync(Id);
        }

        // Asynchronously delete a given Supplier from the database
        public async Task<bool> DeleteOneAsync(Supplier supplier)
        {
            // Remove the supplier from the DbSet
            _supplier.Remove(supplier);
            // Save changes to the database
            await _databaseContext.SaveChangesAsync();
            return true; // Indicate success
        }

        // Asynchronously update an existing Supplier's information
        public async Task<bool> UpdateOneAsync(Supplier updateSupplier)
        {
            // Update the supplier in the DbSet
            _supplier.Update(updateSupplier);
            // Save changes to the database
            await _databaseContext.SaveChangesAsync();
            return true; // Indicate success
        }
    }
}
