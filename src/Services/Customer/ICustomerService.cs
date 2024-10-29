namespace FusionTech.src.Services.Customer
{
    public interface ICustomerService
    {
        Task<List<CustomerReadDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CustomerReadDto> GetOneById(int customerId);
        Task<CustomerReadDto> CreateOneAsync(CustomerSignUpDTO createDto);
        Task<int> getAgeByEmailAsync(string userEmail);
        Task<string> SignInAsCustomer(string email);
        Task<string> SignInAsCustomer(string email, int age);
        Task<bool> UpdateAgeAsync(string email, int age);
        Task<int> CountCustomersAsync();
    }
}
