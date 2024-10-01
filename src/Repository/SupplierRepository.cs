using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class SupplierRepository
    {
        protected DbSet<Supplier> _supplier;
        protected DatabaseContext _databaseContext;

        public SupplierRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _supplier = databaseContext.Set<Supplier>();
        }

        public async Task<Supplier> CreateOneAsync(Supplier newSupplier)
        {
            await _supplier.AddAsync(newSupplier);
            await _databaseContext.SaveChangesAsync();
            return newSupplier;
        }

        public async Task<List<Supplier>> GetAllAsync()
        {
            return await _supplier.ToListAsync();
        }

        public async Task<Supplier?> GetByIdAsync(Guid id)
        {
            return await _supplier.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(Supplier supplier)
        {
            _supplier.Remove(supplier);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Supplier updateSupplier)
        {
            _supplier.Update(updateSupplier);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
