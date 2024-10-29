namespace FusionTech.src.Services.SystemAdmin
{
    public interface ISystemAdminService
    {
        Task<List<SystemAdminReadDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<SystemAdminReadDto> CreateOneAsync(SystemAdminSignUpDTO createDto, string email);
        Task<bool> DeletePersonAsync(int id, string adminEmail);
        Task<int> CountSystemAdminsAsync();
        Task<SystemAdminReadDto> GetOneById(int id);
    }
}
