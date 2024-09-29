using static sda_3_online_Backend_Teamwork.src.DTO.StudioDTO;

namespace sda_3_online_Backend_Teamwork.src.Service.Studio
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
