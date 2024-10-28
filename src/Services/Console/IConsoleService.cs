namespace FusionTech.src.Services.Console
{
    public interface IConsoleService
    {
        Task<ConsoleReadDTO> CreateOneAsync(ConsoleCreateDto createDTO);
        Task<List<ConsoleReadDTO>> GetAllAsync();
        Task<ConsoleReadDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, ConsoleUpdateDTO ConsoleName);
    }
}
