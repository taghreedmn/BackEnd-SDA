using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FusionTech.src.Entity;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SupplierController : ControllerBase
    {
        public List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier
            {
                SupplierId = 1,
                SupplierName = "Supplier A",
                SupplierContact = "123-456-7890",
                SupplierBankInfo = "Bank A Info"
            },
            new Supplier
            {
                SupplierId = 2,
                SupplierName = "Supplier B",
                SupplierContact = "987-654-3210",
                SupplierBankInfo = "Bank B Info"
            },
            new Supplier
            {
                SupplierId = 3,
                SupplierName = "Supplier C",
                SupplierContact = "555-555-5555",
                SupplierBankInfo = "Bank C Info"
            }
        };

        // Get all suppliers
        [HttpGet]
        public ActionResult GetSuppliers()
        {
            return Ok(suppliers);
        }

        // Get supplier by ID
        [HttpGet("{id}")]
        public ActionResult GetSupplierById(int id)
        {
            Supplier? foundSupplier = suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (foundSupplier == null)
            {
                return NotFound();
            }
            return Ok(foundSupplier);
        }

        // Add a new supplier
        [HttpPost]
        public ActionResult CreateSupplier(Supplier newSupplier)
        {
            newSupplier.SupplierId = suppliers.Max(s => s.SupplierId) + 1; // Incrementing SupplierId
            suppliers.Add(newSupplier);
            return CreatedAtAction(
                nameof(GetSupplierById),
                new { id = newSupplier.SupplierId },
                newSupplier
            );
        }

        // Delete supplier
        [HttpDelete("{id}")]
        public ActionResult DeleteSupplier(int id)
        {
            Supplier? foundSupplier = suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (foundSupplier == null)
            {
                return NotFound();
            }
            suppliers.Remove(foundSupplier);
            return NoContent();
        }

        // Update supplier
        [HttpPut("{id}")]
        public ActionResult UpdateSupplier(int id, Supplier updatedSupplier)
        {
            Supplier? foundSupplier = suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (foundSupplier == null)
            {
                return NotFound();
            }

            foundSupplier.SupplierName = updatedSupplier.SupplierName;
            foundSupplier.SupplierContact = updatedSupplier.SupplierContact;
            foundSupplier.SupplierBankInfo = updatedSupplier.SupplierBankInfo;

            return NoContent();
        }
    }
}
