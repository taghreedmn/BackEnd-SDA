namespace FusionTech.src.Services.Inventory

{
    public interface IInventoryService
    {
        Task<InventoryReadDto> CreateOneAsync(InventoryCreateDto inventoryCreateDto);
        Task<List<InventoryReadDto>> GetAllGamesAsync();
        Task<InventoryReadDto> GetGameByIdAsync(Guid id);
        Task<bool> RemoveGameAsync(InventoryModifyGameQuantityDTO inventoryModifyDto);  
        Task<bool> AddGameAsync(InventoryModifyGameQuantityDTO inventoryModifyDto);
    }
}