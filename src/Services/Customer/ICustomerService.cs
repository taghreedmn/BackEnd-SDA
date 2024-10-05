using static FusionTech.src.DTO.CustomerDTO;

namespace FusionTech.src.Services.Customer
{
    public interface ICustomerService
    {
        Task<CustomerReadDto> CreateOneAsync(CustomerSignUpDTO createDto);
        Task<int> getAgeByEmailAsync(string userEmail);

        // We need to change the object into the appropriate type
        Task<object> OrderGameAsync(int customerId, int gameId);
        Task<string> SignInAsCustomer(string email);
        Task<string> SignInAsCustomer(string email, int age);
        Task<bool> UpdateAgeAsync(string email, int age);
    }
}
