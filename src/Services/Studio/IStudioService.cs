namespace FusionTech.src.Services.Studio
{
    public interface IStudioService
    {
        Task<StudioReadDTO> CreateOneAsync(StudioCreateDTO createDTO);
        Task<List<StudioReadDTO>> GetAllAsync();
        Task<StudioReadDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, StudioUpdateDTO studioName);
    }
}
