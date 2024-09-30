using static FusionTech.src.DTO.ConsoleDTO;

namespace FusionTech.src.Service.Console
{
    public interface IConsoleService
    {
        Task<ReadConsoleDTO> CreateOneAsync(CreateConsoleDTO createDTO);
        Task<List<ReadConsoleDTO>> GetAllAsync();
        Task<ReadConsoleDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, UpdateConsoleDTO ConsoleName);
    }
}
