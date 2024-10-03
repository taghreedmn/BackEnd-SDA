using FusionTech.src.Config;
using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class SystemAdminRepository
    {
        protected DbSet<SystemAdmin> _systemAdmin;
        protected DatabaseContext _databaseContext;

        public SystemAdminRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _systemAdmin = _databaseContext.Set<SystemAdmin>();
        }

        public async Task<SystemAdmin> CreateOneAsync(SystemAdmin systemAdmin)
        {
            await _systemAdmin.AddAsync(systemAdmin);
            await _databaseContext.SaveChangesAsync();
            return systemAdmin;
        }

        public async Task<SystemAdmin?> GetByIdAsync(int id)
        {
            return await _systemAdmin.FindAsync(id);
        }
    }
}
