using static FusionTech.src.DTO.PlayedInDTO;

namespace FusionTech.src.Services.PlayedIn
{
    public interface IPlayedInServices
    {

          Task<ReadPlayedInDTO > CreateOneAsync(CreatePlayedInDTO  createDTO);
        Task<List<ReadPlayedInDTO >> GetAllAsync();
        Task<ReadPlayedInDTO> GetIdAsync(Guid id);
        Task<bool> DeleteIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, CreatePlayedInDTO updatePlayed);
        
    }
}