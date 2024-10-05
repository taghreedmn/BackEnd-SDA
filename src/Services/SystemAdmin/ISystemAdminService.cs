using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.src.Services.SystemAdmin
{
    public interface ISystemAdminService
    {
        Task<bool> AddGame();
        Task<bool> DeleteGame();
        Task<SystemAdminReadDto> CreateOneAsync(SystemAdminSignUpDTO createDto, string email);
        Task<bool> DeletePersonAsync(int id, string adminEmail);
    }
}
