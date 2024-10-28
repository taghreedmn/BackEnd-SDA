namespace FusionTech.src.Repository
{
    public class ConsoleRepository
    {
        protected DbSet<GameConsole> _console;
        protected DatabaseContext _databaseContext;

        public ConsoleRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _console = databaseContext.Set<GameConsole>();
        }

        public async Task<GameConsole> CreateOneAsync(GameConsole newConsole)
        {
            await _console.AddAsync(newConsole);
            await _databaseContext.SaveChangesAsync();
            return newConsole;
        }

        public async Task<GameConsole> GetIdAsync(Guid id)
        {
            return await _console.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(GameConsole Console)
        {
            _console.Remove(Console);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(GameConsole updateConsole)
        {
            _console.Update(updateConsole);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<GameConsole>> GetAllAsync()
        {
            return await _console.ToListAsync();
        }
    }
}
