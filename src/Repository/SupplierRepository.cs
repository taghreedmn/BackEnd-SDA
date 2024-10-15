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
            if (supplier == null) throw new ArgumentNullException(nameof(supplier));
            
            _supplier.Remove(supplier);
            return await _databaseContext.SaveChangesAsync() > 0;
        }


        public async Task<bool> UpdateOneAsync(Supplier updateSupplier)
        {
            if (updateSupplier == null) throw new ArgumentNullException(nameof(updateSupplier));

            _supplier.Update(updateSupplier);
            return await _databaseContext.SaveChangesAsync() > 0;
        }
    }
}
