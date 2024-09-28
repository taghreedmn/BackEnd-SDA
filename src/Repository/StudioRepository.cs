using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace sda_3_online_Backend_Teamwork.src.Repository
{
    public class StudioRepository
    {
        protected DbSet<GameStudio> _studio;
        protected DatabaseContext _databaseContext;

        public StudioRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _studio = databaseContext.Set<GameStudio>();
        }

        public async Task<GameStudio> CreateOneAsync(GameStudio newStudio)
        {
            await _studio.AddAsync(newStudio);
            await _databaseContext.SaveChangesAsync();
            return newStudio;
        }

        public async Task<GameStudio> GetIdAsync(Guid id)
        {
            return await _studio.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(GameStudio studio)
        {
            _studio.Remove(studio);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(GameStudio updateStudio)
        {
            _studio.Update(updateStudio);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<GameStudio>> GetAllAsync()
        {
            return await _studio.ToListAsync();
        }
    }
}
