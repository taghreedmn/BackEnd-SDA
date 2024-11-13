namespace FusionTech.src.Services.Inventory

{
    public interface IInventoryService
    {
        Task<InventoryReadDto> CreateOneAsync(InventoryCreateDto inventoryCreateDto);
        Task<List<InventoryReadDto>> GetAllGamesAsync();
        Task<Guid> GetStoreIdByVideoGameVersionId(Guid id);
        Task<bool> RemoveGameAsync(InventoryUpdateDTO inventoryUpdateDTO);  
        Task<bool> AddGameAsync(InventoryUpdateDTO inventoryUpdateDTO);
    }
}