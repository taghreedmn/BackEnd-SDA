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

        // Here the person is already there (admin or employee)
        public async Task<Customer> CreateCustomerRawSqlAsync(int personId, int age)
        {
            var sql = "INSERT INTO \"Customers\" (\"PersonId\", \"Age\") VALUES (@personId, @age)";

            await _databaseContext.Database.ExecuteSqlRawAsync(
                sql,
                new Npgsql.NpgsqlParameter("@personId", personId),
                new Npgsql.NpgsqlParameter("@age", age)
            );
            return (await GetByIdAsync(personId))!;
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _Customer.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            _Customer.Update(customer);
            return await _databaseContext.SaveChangesAsync() > 0;
        }
    }
}
