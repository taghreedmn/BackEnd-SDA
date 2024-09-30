using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class SupplyRepository
    {
        // DbSet for accessing Supply entities in the database
        protected DbSet<Supply> _supply;

        // Database context for interacting with the database
        protected DatabaseContext _databaseContext;

        // Constructor that initializes the repository with a DatabaseContext
        public SupplyRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

            // Initialize the _supply DbSet for the Supply entity
            _supply = databaseContext.Set<Supply>();
        }

        // Asynchronously create a new Supply and save it to the database
        public async Task<Supply> CreateOneAsync(Supply newSupply)
        {
            // Add the new supply to the DbSet
            await _supply.AddAsync(newSupply);
            // Save changes to the database
            await _databaseContext.SaveChangesAsync();
            return newSupply; // Return the created supply
        }

        // Asynchronously retrieve a Supply by its ID
        public async Task<Supply?> GetByIdAsync(int Id)
        {
            // Find and return the supply by ID
            return await _supply.FindAsync(Id);
        }

        // Asynchronously delete a given Supply from the database
        public async Task<bool> DeleteOneAsync(Supply supply)
        {
            // Remove the supply from the DbSet
            _supply.Remove(supply);
            // Save changes to the database
            await _databaseContext.SaveChangesAsync();
            return true; // Indicate success
        }

        // Asynchronously update an existing Supply's information
        public async Task<bool> UpdateOneAsync(Supply updateSupply)
        {
            // Update the supply in the DbSet
            _supply.Update(updateSupply);
            // Save changes to the database
            await _databaseContext.SaveChangesAsync();
            return true; // Indicate success
        }
    }
}
