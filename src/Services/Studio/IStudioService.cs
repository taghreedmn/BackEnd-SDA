using static FusionTech.src.DTO.StudioDTO;

namespace FusionTech.src.Service.Studio
{
    public interface IStudioService
    {
        Task<ReadStudioDTO> CreateOneAsync(CreatStudioDTO createDTO);
        Task<List<ReadStudioDTO>> GetAllAsync();
        Task<ReadStudioDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, UpdateStudioDTO studioName);
    }
}
