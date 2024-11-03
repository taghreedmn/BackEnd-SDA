namespace FusionTech.src.Services.Inventory
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

        public async Task<List<InventoryReadDto>> GetAllGamesAsync()
        {
            var inventoryList = await _inventoryRepo.GetAllAsync();
            return _mapper.Map<List<Entity.Inventory>, List<InventoryReadDto>>(inventoryList);
        }

        public async Task<Guid> GetStoreIdByVideoGameVersionId(Guid id)
        {
            var foundInventory =
                await _inventoryRepo.GetStoreIdByVideoGameVersionId(id)
                ?? throw CustomException.NotFound();
            return foundInventory;
        }

        // public async Task<bool> RemoveGameAsync(Guid id)
        // {
        //     var foundInventory = await _inventoryRepo.GetByIdAsync(id);
        //     bool isDeleted = await _inventoryRepo.DeleteOnAsync(foundInventory);
        //     if (isDeleted)
        //     {
        //         return true;
        //     }
        //     return false;
        // }


        public async Task<bool> AddGameAsync(InventoryUpdateDTO inventoryUpdateDTO)
        {
            var foundInventory = await _inventoryRepo.GetByIdAsync(
                inventoryUpdateDTO.StoreId,
                inventoryUpdateDTO.VideoGameVersionId
            );
            if (foundInventory == null)
            {
                return false;
            }
            foundInventory.GameQuantity += inventoryUpdateDTO.GameQuantity;
            return await _inventoryRepo.UpdateOnAsync(foundInventory);
        }

        // Remove a game from the inventory
        public async Task<bool> RemoveGameAsync(InventoryUpdateDTO inventoryUpdateDTO)
        {
            var foundInventory = await _inventoryRepo.GetByIdAsync(
                inventoryUpdateDTO.StoreId,
                inventoryUpdateDTO.VideoGameVersionId
            );
            if (foundInventory == null)
            {
                return false;
            }
            foundInventory.GameQuantity -= inventoryUpdateDTO.GameQuantity;
            if (foundInventory.GameQuantity < 0)
            {
                return false;
            }
            return await _inventoryRepo.UpdateOnAsync(foundInventory);
        }
    }
}
