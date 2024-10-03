using FusionTech.src.Database;
using Microsoft.EntityFrameworkCore;
using FusionTech.src.Entity;

namespace FusionTech.src.Repository
{
    public class DevelopedByRepository
    {

         protected DbSet<Developed> _developedBy;
        protected DatabaseContext _databaseContext;

        public DevelopedByRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
           _developedBy = databaseContext.Set<Developed>();
        }

        public async Task<Developed> CreateOneAsync(Developed newDevelopedBy)
        {
            await _developedBy.AddAsync(newDevelopedBy);
            await _databaseContext.SaveChangesAsync();
            return newDevelopedBy;
        }

        public async Task<Developed> GetIdAsync(Guid id)
        {
            return await _developedBy.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(Developed developedBy)
        {
            _developedBy.Remove(developedBy);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Developed updatedevelopedBy)
        {
           _developedBy.Update(updatedevelopedBy);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Developed>> GetAllAsync()
        {
            return await _developedBy.ToListAsync();
        }
        
    }
}