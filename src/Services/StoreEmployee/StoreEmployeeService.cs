using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.StoreEmployeeDTO;

namespace FusionTech.src.Services.StoreEmployee
{
    public class StoreEmployeeService : IStoreEmployeeService
    {
        public Task<CustomerReadDto> SignInAsCustomer(StoreEmployeeReadDto readDto)
        {
            throw new NotImplementedException();
        }

        public Task<StoreEmployeeReadDto> SignUpEmployee(StoreEmployeeSignUpDTO createDto)
        {
            throw new NotImplementedException();
        }

        public Task ViewSalary(StoreEmployeeReadDto readDto)
        {
            throw new NotImplementedException();
        }
    }
}
