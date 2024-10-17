namespace FusionTech.src.Services.Studio
{
    public interface IStudioService
    {
        Task<ReadStudioDTO> CreateOneAsync(CreateStudioDTO createDTO);
        Task<List<ReadStudioDTO>> GetAllAsync();
        Task<ReadStudioDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, UpdateStudioDTO studioName);
    }
}
