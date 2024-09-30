using FusionTech.src.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SupplyController : ControllerBase
    {
        private List<Supply> supplies = new List<Supply>
        {
            new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Guid.NewGuid(),
                GamesId = Guid.NewGuid(),
                SupplierQuantity = 50,
                SupplierDate = new DateTime(2020, 12, 12),
                InventoryId = Guid.NewGuid(),
            },
            new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Guid.NewGuid(),
                GamesId = Guid.NewGuid(),
                SupplierQuantity = 100,
                SupplierDate = new DateTime(2019, 1, 10),
                InventoryId = Guid.NewGuid(),
            },
            new Supply
            {
                SupplyId = Guid.NewGuid(),
                SupplierId = Guid.NewGuid(),
                GamesId = Guid.NewGuid(),
                SupplierQuantity = 250,
                SupplierDate = new DateTime(2022, 3, 4),
                InventoryId = Guid.NewGuid(),
            },
        };

        // Get all supplies
        [HttpGet]
        public ActionResult<IEnumerable<Supply>> GetSupplies()
        {
            return Ok(supplies);
        }

        // Get supply by ID
        [HttpGet("{id}")]
        public ActionResult<Supply> GetSupplyById(Guid id) // Change to Guid
        {
            var supplyItem = supplies.FirstOrDefault(s => s.SupplyId == id); // Use SupplyId
            if (supplyItem == null)
            {
                return NotFound();
            }
            return Ok(supplyItem);
        }

        // Create a new supply
        [HttpPost]
        public ActionResult<Supply> CreateSupply(Supply newSupply)
        {
            newSupply.SupplyId = Guid.NewGuid(); // Generate new SupplyId
            supplies.Add(newSupply);
            return CreatedAtAction(
                nameof(GetSupplyById),
                new { id = newSupply.SupplyId },
                newSupply
            );
        }

        // Update supply
        [HttpPut("{id}")]
        public ActionResult UpdateSupply(Guid id, Supply updatedSupply) // Change to Guid
        {
            var supplyItem = supplies.FirstOrDefault(s => s.SupplyId == id); // Use SupplyId
            if (supplyItem == null)
            {
                return NotFound();
            }

            supplyItem.GamesId = updatedSupply.GamesId;
            supplyItem.SupplierQuantity = updatedSupply.SupplierQuantity;
            supplyItem.SupplierDate = updatedSupply.SupplierDate;
            supplyItem.InventoryId = updatedSupply.InventoryId;

            return NoContent();
        }

        // Delete supply
        [HttpDelete("{id}")]
        public ActionResult DeleteSupply(Guid id) // Change to Guid
        {
            var supplyItem = supplies.FirstOrDefault(s => s.SupplyId == id); // Use SupplyId
            if (supplyItem == null)
            {
                return NotFound();
            }
            supplies.Remove(supplyItem);
            return NoContent();
        }
    }
}
