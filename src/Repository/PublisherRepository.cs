namespace FusionTech.src.Repository
{
    public class PublisherRepository 
    {

        protected DbSet<Publisher> _publisher;
        protected DatabaseContext _databaseContext;

        public PublisherRepository (DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

            _publisher = databaseContext.Set<Publisher> ();
        }
        public async Task<Publisher> CreateOneAsync(Publisher newPublisher)
        {
            await _publisher.AddAsync (newPublisher);
            await _databaseContext.SaveChangesAsync();
            return newPublisher;

        }
        public async Task<List<Publisher>> GetAllAsync()
        {
            return await _publisher.ToListAsync();
        }

        public async Task<Publisher> GetIdAsync(Guid id)
        {
            return await _publisher.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(Publisher publisher)
        {
            _publisher.Remove(publisher);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Publisher updatePublisher)
        {
            _publisher.Update(updatePublisher);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}