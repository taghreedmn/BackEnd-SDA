using static FusionTech.src.DTO.SupplyDTO;

namespace FusionTech.src.Services.supply
{

    public interface ISupplyService
    {
        Task<SupplyReadDto> CreateOneAsync(SupplyCreateDto creatDto);

        Task<List<SupplyReadDto>> GetAllAsync();
        Task<SupplyReadDto> GetByIdAsync(Guid Id);
        Task<bool> DeleteOneAsync(Guid Id);
        Task<bool> UpdateOnAsync(Guid ID, SupplyUpdateDto updateDto);

    }
}