using static sda_3_online_Backend_Teamwork.src.DTO.ConsoleDTO;

namespace FusionTech.Service.Console
{
    public interface IConsoleService
    {

        
        Task<ReadConsoleDTO> CreateOneAsync(CreatConsoleDTO createDTO);
        Task<List<ReadConsoleDTO>> GetAllAsync();
        Task<ReadConsoleDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id , UpdateConsoleDTO ConsoleName);
        
    }
}