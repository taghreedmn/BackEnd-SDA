using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.StoreEmployeeDTO;

namespace FusionTech.src.Services.StoreEmployee
{
    public interface IStoreEmployeeService
    {
        Task<StoreEmployeeReadDto> SignUpEmployee(StoreEmployeeSignUpDTO createDto);
        Task<CustomerReadDto> SignInAsCustomer(StoreEmployeeReadDto readDto);
        Task ViewSalary(StoreEmployeeReadDto readDto);
    }
}
