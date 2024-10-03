using FusionTech.src.Database;
using Microsoft.EntityFrameworkCore;
using FusionTech.src.Entity;

namespace FusionTech.src.Repository
{
    public class PlayedInRepository
    {
        protected DbSet<Played> _playedIn;
        protected DatabaseContext _databaseContext;

        public PlayedInRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _playedIn = databaseContext.Set<Played>();
        }

        public async Task<Played> CreateOneAsync(Played newPlayedIn)
        {
            await _playedIn.AddAsync(newPlayedIn);
            await _databaseContext.SaveChangesAsync();
            return newPlayedIn;
        }

        public async Task<Played> GetIdAsync(Guid id)
        {
            return await _playedIn.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(Played playedIn)
        {
            _playedIn.Remove(playedIn);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Played updateplayedIn)
        {
            _playedIn.Update(updateplayedIn);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Played>> GetAllAsync()
        {
            return await _playedIn.ToListAsync();
        }
    }
}
