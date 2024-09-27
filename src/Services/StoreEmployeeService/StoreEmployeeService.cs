using FusionTech.src.DTO;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.StoreEmployeeDTO;

namespace FusionTech.Service.StoreEmployeeService
{
    public class StoreEmployeeService : IStoreEmployeeService
    {
        public Task<CustomerReadDto> SignInAsCustomer(StoreEmployeeReadDto readDto)
        {
            throw new NotImplementedException();
        }

        public Task<StoreEmployeeReadDto> SignUpEmployee(StoreEmployeeCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task ViewSalary(StoreEmployeeReadDto readDto)
        {
            throw new NotImplementedException();
        }
    }
}
