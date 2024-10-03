using FusionTech.src.Services.Inventory;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.InventoryDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class InventoryController : ControllerBase
    {
        protected readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // Creates a new inventory Game
        [HttpPost]
        public async Task<ActionResult<InventoryReadDto>> CreateOne(
            [FromBody] InventoryCreateDto createDto
        )
        {
            var inventoryCreated = await _inventoryService.CreateOneAsync(createDto);
            return Created($"api/v1/inventory/{inventoryCreated.InventoryId}", inventoryCreated);
        }

        // Retrieves all inventory Games with pagination
        [HttpGet]
        public async Task<ActionResult<List<InventoryReadDto>>> GetAllItems()
        {
            var inventoryList = await _inventoryService.GetAllGamesAsync();
            return Ok(inventoryList);
        }

        // Retrieves an inventory Game by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryReadDto>> GetItemById([FromRoute] Guid id)
        {
            var inventoryItem = await _inventoryService.GetGameByIdAsync(id);
            if (inventoryItem == null)
            {
                return NotFound();
            }
            return Ok(inventoryItem);
        }

        // Updates an inventory item by ID
        // [HttpPut("{id}")]
        // public async Task<ActionResult> UpdateItem(
        //     [FromRoute] Guid id,
        //     [FromBody] InventoryUpdateDto updateDto
        // ) { }

        // Adds a game to the inventory
        [HttpPost("add-game")]
        public async Task<ActionResult> AddGameToInventory(
            [FromBody] InventoryModifyGameQuantityDTO modifyGameQuantityDto
        )
        {
            var gameAdded = await _inventoryService.AddGameAsync(modifyGameQuantityDto);
            if (!gameAdded)
            {
                return NotFound();
            }
            return NoContent(); // No content returned on successful addition
        }

        // Removes a game from the inventory
        [HttpDelete("remove-game")]
        public async Task<ActionResult> RemoveGameFromInventory(
            [FromBody] InventoryModifyGameQuantityDTO modifyGameQuantityDto
        )
        {
            var gameRemoved = await _inventoryService.RemoveGameAsync(modifyGameQuantityDto);
            if (!gameRemoved)
            {
                return NotFound();
            }
            return NoContent(); // No content returned on successful removal
        }
    }
}
