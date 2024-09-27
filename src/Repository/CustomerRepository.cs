using FusionTech.src.Config;
using FusionTech.src.Database;
using FusionTech.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class CustomerRepository
    {
        protected DbSet<Customer> _Customer;
        protected DatabaseContext _databaseContext;

        public CustomerRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _Customer = _databaseContext.Set<Customer>();
        }

        public async Task<Customer> CreateOneAsync(Customer customer)
        {
            await _Customer.AddAsync(customer);
            await _databaseContext.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _Customer.FindAsync(id);
        }

        public async Task<int> GetNextIdCustomerAsync()
        {
            var counter = await _databaseContext.PersonIdCounters.SingleOrDefaultAsync(c =>
                c.PersonIdCounterId == Customer.PersonType
            );

            // Increment the counter
            counter.CurrentId++;
            await _databaseContext.SaveChangesAsync();

            // Return the calculated ID
            return PersonIdConfig.CustomerStartIndex + counter.CurrentId;
        }
    }
}
