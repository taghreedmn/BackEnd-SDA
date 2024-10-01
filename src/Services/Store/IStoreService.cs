
using static FusionTech.src.DTO.StoreDTO;

namespace FusionTech.src.Service.Store
{
    public interface IStoreService
    {
        Task<StoreReadDto> CreateOneAsync(StoreCreateDto newStore); 
        Task<StoreReadDto> GetByIdAsync(Guid id); 
        Task<List<StoreReadDto>> GetAllAsync(); 
        Task<bool> UpdateOneAsync(StoreUpdateDto updateStore); 
        Task<bool> DeleteOneAsync(Guid id); 
    }
}
