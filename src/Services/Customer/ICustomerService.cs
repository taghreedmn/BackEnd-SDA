using static FusionTech.src.DTO.CustomerDTO;

namespace FusionTech.Service.Customer
{
    public interface ICustomerService
    {
        Task<CustomerReadDto> CreateOneAsync(CustomerCreateDto createDto);

        Task<bool> UpdateNameAsync(int customerId, string name);
        Task<bool> UpdateAgeAsync(int customerId, int age);

        // We need to change the object into the appropriate type
        Task<object> OrderGameAsync(int customerId, int gameId);
    }
}
