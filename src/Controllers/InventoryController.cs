using FusionTech.src.Service.Inventory;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.Entity.InventoryDTO;

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

        // Creates a new inventory item
        [HttpPost]
        public async Task<ActionResult<InventoryReadDto>> CreateOne(
            [FromBody] InventoryCreateDto createDto
        )
        {
            var inventoryCreated = await _inventoryService.CreateOneAsync(createDto);
            return Created($"api/v1/inventory/{inventoryCreated.InventoryId}", inventoryCreated);
        }

        // Retrieves all inventory items with pagination
        [HttpGet]
        public async Task<ActionResult<List<InventoryReadDto>>> GetAllItems()
        {
            var inventoryList = await _inventoryService.GetAllItemsAsync();
            return Ok(inventoryList);
        }

        // Retrieves an inventory item by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryReadDto>> GetItemById([FromRoute] Guid id)
        {
            var inventoryItem = await _inventoryService.GetItemByIdAsync(id);
            if (inventoryItem == null)
            {
                return NotFound();
            }
            return Ok(inventoryItem);
        }

        // Updates an inventory item by ID
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateItem(
            [FromRoute] Guid id,
            [FromBody] InventoryUpdateDto updateDto
        )
        {
            var itemUpdated = await _inventoryService.UpdateItemAsync(id, updateDto);
            if (!itemUpdated)
            {
                return NotFound();
            }
            return NoContent();
        }

        // Deletes an inventory item
        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveItem([FromRoute] Guid id)
        {
            var itemRemoved = await _inventoryService.RemoveItemAsync(id);
            if (!itemRemoved)
            {
                return NotFound();
            }
            return NoContent(); // No content returned on successful deletion
        }
    }
}
