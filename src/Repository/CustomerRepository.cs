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

        public async Task<Customer> SignUp(
            string name,
            string email,
            string password,
            string phone,
            string profilePicturePath,
            int age
        )
        {
            Customer customer = new Customer(name, email, password, phone, profilePicturePath, age);
            await _Customer.AddAsync(customer);
            await _databaseContext.SaveChangesAsync();
            return customer;
        }
    }
}
