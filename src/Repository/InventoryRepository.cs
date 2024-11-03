namespace FusionTech.src.Repository
{
    public class InventoryRepository
    {
        protected DbSet<Inventory> _Inventory;
        protected DatabaseContext _databaseContext;

        public InventoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _Inventory = databaseContext.Set<Inventory>();
        }

        public async Task<Inventory?> GetByIdAsync(Guid storeId, Guid videoGameVersionId)
        {
            return await _Inventory.FirstOrDefaultAsync(i =>
                i.StoreId == storeId && i.VideoGameVersionId == videoGameVersionId
            );
        }

        public async Task<Guid?> GetStoreIdByVideoGameVersionId(Guid videoGameVersionId)
        {
            var storeId = await _Inventory
                .Where(i => i.VideoGameVersionId == videoGameVersionId)
                .Select(i => i.StoreId)
                .FirstOrDefaultAsync();

            return storeId;
        }

        public async Task<Inventory> CreateOneAsync(Inventory newInventory)
        {
            await _Inventory.AddAsync(newInventory);
            await _databaseContext.SaveChangesAsync();
            return newInventory;
        }

        public async Task<List<Inventory>> GetAllAsync()
        {
            return await _Inventory.ToListAsync();
        }

        public async Task<bool> UpdateOnAsync(Inventory updateInventory)
        {
            _Inventory.Update(updateInventory);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteOnAsync(Inventory inventory)
        {
            _Inventory.Remove(inventory);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
