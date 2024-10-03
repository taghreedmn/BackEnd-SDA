using static FusionTech.src.DTO.CustomerDTO;
using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.src.Services.SystemAdmin
{
    public interface ISystemAdminService
    {
        // We need to add GameReadDto here
        Task<bool> AddGame();
        Task<bool> DeleteGame();
        Task<SystemAdminReadDto> CreateOneAsync(SystemAdminSignUpDTO createDto, string email);
    }
}
