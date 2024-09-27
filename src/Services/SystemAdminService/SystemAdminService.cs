using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.Service.SystemAdminService
{
    public class SystemAdminService : ISystemAdminService
    {
        public Task<bool> AddGame()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGame()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerReadDto> SignInAsCustomer(SystemAdminCreateDto readDto)
        {
            throw new NotImplementedException();
        }

        public Task<SystemAdminReadDto> SignUpAdmin(SystemAdminCreateDto createDto)
        {
            throw new NotImplementedException();
        }
    }
}
