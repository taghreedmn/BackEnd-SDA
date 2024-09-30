using FusionTech.src.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SupplierController : ControllerBase
    {
        private List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Supplier A",
                SupplierContact = "123-456-7890",
                SupplierBankInfo = "Bank A Info",
            },
            new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Supplier B",
                SupplierContact = "987-654-3210",
                SupplierBankInfo = "Bank B Info",
            },
            new Supplier
            {
                SupplierId = Guid.NewGuid(),
                SupplierName = "Supplier C",
                SupplierContact = "555-555-5555",
                SupplierBankInfo = "Bank C Info",
            },
        };

        // Get all suppliers
        [HttpGet]
        public ActionResult<IEnumerable<Supplier>> GetSuppliers()
        {
            return Ok(suppliers);
        }

        // Get supplier by ID
        [HttpGet("{id}")]
        public ActionResult<Supplier> GetSupplierById(Guid id) // Change to Guid
        {
            var foundSupplier = suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (foundSupplier == null)
            {
                return NotFound();
            }
            return Ok(foundSupplier);
        }

        // Add a new supplier
        [HttpPost]
        public ActionResult<Supplier> CreateSupplier(Supplier newSupplier)
        {
            newSupplier.SupplierId = Guid.NewGuid(); // Generate new SupplierId
            suppliers.Add(newSupplier);
            return CreatedAtAction(
                nameof(GetSupplierById),
                new { id = newSupplier.SupplierId },
                newSupplier
            );
        }

        // Delete supplier
        [HttpDelete("{id}")]
        public ActionResult DeleteSupplier(Guid id) // Change to Guid
        {
            var foundSupplier = suppliers.FirstOrDefault(s => s.SupplierId == id);
            if (foundSupplier == null)
            {
                return NotFound();
            }
            suppliers.Remove(foundSupplier);
            return NoContent();
        }

        // Update supplier
        [HttpPut("{id}")]
        public ActionResult UpdateSupplier(Guid id, Supplier updatedSupplier) // Change to Guid
        {
            var foundSupplier = suppliers.FirstOrDefault(s => s.SupplierId == id);
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
