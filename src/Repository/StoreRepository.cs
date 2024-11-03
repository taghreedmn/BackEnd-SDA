namespace FusionTech.src.Repository
{
    public class StoreRepository
    {
        protected DbSet<Store> _Store;
        protected DatabaseContext _databaseContext;

        public StoreRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _Store = databaseContext.Set<Store>();
        }

        // Get store by ID
        public async Task<Store?> GetByIdAsync(Guid id)
        {
            var store = await _Store
                .Include(s => s.storeEmployees)
                .Include(s => s.Orders)
                .Include(s => s.Inventories)
                .FirstOrDefaultAsync(s => s.StoreId == id);

            return store ?? null;
        }

        // Create a new store
        public async Task<Store> CreateOneAsync(Store newStore)
        {
            await _Store.AddAsync(newStore);
            await _databaseContext.SaveChangesAsync();
            return newStore;
        }

        // Get all stores
        public async Task<List<Store>> GetAllAsync()
        {
            return await _Store.ToListAsync();
        }

        // Update a store
        public async Task<bool> UpdateOneAsync(Store updateStore)
        {
            _Store.Update(updateStore);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        // Delete a store
        public async Task<bool> DeleteOneAsync(Store store)
        {
            _Store.Remove(store);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
