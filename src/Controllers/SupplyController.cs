using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FusionTech.src.Entity;

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
                SupplierId = 1,
                GamesId = 1,
                SupplierQuantity = 50,
                SupplierDate = new DateTime(2020, 12, 12),
                InventoryId = 1
            },
            new Supply
            { 
                SupplierId = 2,
                GamesId = 2,
                SupplierQuantity = 100,
                SupplierDate = new DateTime(2019, 1, 10),
                InventoryId = 2
            },
            new Supply 
            { 
                SupplierId = 3,
                GamesId = 3,
                SupplierQuantity = 250,
                SupplierDate = new DateTime(2022, 3, 4),
                InventoryId = 3
            }
        };

        // Get all supplies
        [HttpGet]
        public ActionResult<IEnumerable<Supply>> GetSupplies()
        {
            return Ok(supplies);
        }

        // Get supply by ID
        [HttpGet("{id}")]
        public ActionResult<Supply> GetSupplyById(int id)
        {
            var supplyItem = supplies.FirstOrDefault(s => s.SupplierId == id);
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
            newSupply.SupplierId = supplies.Max(s => s.SupplierId) + 1; // Increment SupplierId
            supplies.Add(newSupply);
            return CreatedAtAction(nameof(GetSupplyById), new { id = newSupply.SupplierId }, newSupply);
        }

        // Update supply
        [HttpPut("{id}")]
        public ActionResult UpdateSupply(int id, Supply updatedSupply)
        {
            var supplyItem = supplies.FirstOrDefault(s => s.SupplierId == id);
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
        public ActionResult DeleteSupply(int id)
        {
            var supplyItem = supplies.FirstOrDefault(s => s.SupplierId == id);
            if (supplyItem == null)
            {
                return NotFound();
            }
            supplies.Remove(supplyItem);
            return NoContent();
        }


    }
}
