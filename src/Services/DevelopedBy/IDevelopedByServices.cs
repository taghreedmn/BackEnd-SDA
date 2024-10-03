using static FusionTech.src.Entity.DevelopedByDTO;

namespace FusionTech.src.Services.DevelopedBy
{
    public interface IDevelopedByServices
    {
        Task<ReadDevelopedByDTO> CreateOneAsync(CreateDevelopedByDTO createDTO);
        Task<List<ReadDevelopedByDTO>> GetAllAsync();
        Task<ReadDevelopedByDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, CreateDevelopedByDTO updateDeveloped);
    }
}
