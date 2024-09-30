using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FusionTech.src.Entity.InventoryDTO;

namespace FusionTech.src.Service.Console
{
    public interface IInventoryService
    {
        Task<InventoryReadDto> CreateOneAsync(InventoryCreateDto inventoryCreateDto);
        Task<List<InventoryReadDto>> GetAllItemsAsync();
        Task<InventoryReadDto> GetItemByIdAsync(Guid id);
        Task<bool> RemoveItemAsync(Guid id);
        Task<bool> UpdateItemAsync(Guid id, InventoryUpdateDto inventoryUpdateDto);
    }
}