namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SupplierReadDto>>> GetAllSuppliers()
        {
            var suppliers = await _supplierService.GetAllAsync();
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierReadDto>> GetSupplierById(Guid id)
        {
            var supplier = await _supplierService.GetByIdAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return Ok(supplier);
        }

        [HttpPost]
        public async Task<ActionResult<SupplierReadDto>> CreateSupplier(SupplierCreateDto createDto)
        {
            var supplierCreated = await _supplierService.CreateOneAsync(createDto);
            return Created($"api/v1/supplier/{supplierCreated.SupplierId}", supplierCreated);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "EmployeeOrAdmin")]
        public async Task<IActionResult> UpdateSupplier(Guid id, SupplierUpdateDto updateDto)
        {
            var foundSupplier = await _supplierService.GetByIdAsync(id);
            if (foundSupplier == null)
            {
                return NotFound();
            }

            await _supplierService.UpdateOneAsync(id, updateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "EmployeeOrAdmin")]
        public async Task<IActionResult> DeleteSupplier(Guid id)
        {
            var foundSupplier = await _supplierService.GetByIdAsync(id);
            if (foundSupplier == null)
            {
                return NotFound();
            }

            await _supplierService.DeleteOneAsync(id);
            return NoContent();
        }
    }
}
