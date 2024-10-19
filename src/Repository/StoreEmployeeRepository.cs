namespace FusionTech.src.Repository
{
    public class StoreEmployeeRepository
    {
        protected DbSet<StoreEmployee> _storeEmployee;
        protected DatabaseContext _databaseContext;

        public StoreEmployeeRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _storeEmployee = _databaseContext.Set<StoreEmployee>();
        }

        public async Task<StoreEmployee> CreateOneAsync(StoreEmployee systemAdmin)
        {
            await _storeEmployee.AddAsync(systemAdmin);
            await _databaseContext.SaveChangesAsync();
            return systemAdmin;
        }

        public async Task<StoreEmployee?> GetByIdAsync(int id)
        {
            return await _storeEmployee.FindAsync(id);
        }
    }
}
