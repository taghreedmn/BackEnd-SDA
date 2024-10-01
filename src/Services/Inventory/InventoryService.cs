using AutoMapper;
using FusionTech.src.Entity;
using static FusionTech.src.Entity.InventoryDTO;

namespace FusionTech.src.Service.Inventory
{
    public class InventoryService : IInventoryService
    {
        protected readonly InventoryRepository _inventoryRepo;
        protected readonly IMapper _mapper;

        public InventoryService(InventoryRepository inventoryRrepo, IMapper mapper)
        {
            _inventoryRepo = inventoryRrepo;
            _mapper = mapper;
        }

        public async Task<InventoryReadDto> CreateOneAsync(InventoryCreateDto inventoryCreateDto)
        {
            var inventory = _mapper.Map<InventoryCreateDto, Entity.Inventory>(inventoryCreateDto);
            var inventoryAdded = await _inventoryRepo.CreateOneAsync(inventory);
            return _mapper.Map<Entity.Inventory, InventoryReadDto>(inventoryAdded);
        }

        public async Task<List<InventoryReadDto>> GetAllItemsAsync()
        {
            var inventoryList = await _inventoryRepo.GetAllAsync();
            return _mapper.Map<List<Entity.Inventory>, List<InventoryReadDto>>(inventoryList);
        }

        public async Task<InventoryReadDto> GetItemByIdAsync(Guid id)
        {
            var foundInventory = await _inventoryRepo.GetByIdAsync(id);
            return _mapper.Map<Entity.Inventory, InventoryReadDto>(foundInventory);
        }

        public async Task<bool> RemoveItemAsync(Guid id)
        {
            var foundInventory = await _inventoryRepo.GetByIdAsync(id);
            bool isDeleted = await _inventoryRepo.DeleteOnAsync(foundInventory);
            if (isDeleted)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateItemAsync(Guid id, InventoryUpdateDto inventoryUpdateDto)
        {
            var foundInventory = await _inventoryRepo.GetByIdAsync(id);

            if (foundInventory == null)
            {
                return false;
            }
            _mapper.Map(inventoryUpdateDto, foundInventory);
            return await _inventoryRepo.UpdateOnAsync(foundInventory);
        }
    }
}
