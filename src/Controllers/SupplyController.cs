using Microsoft.AspNetCore.Mvc;
using FusionTech.src.Entity;
using System.ComponentModel;
using System.Data;
using FusionTech.src.Services.supply;
using FusionTech.src.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.SupplyDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SupplyController : ControllerBase
    {
        protected readonly ISupplyService _supplyService;

        public SupplyController(ISupplyService service)
        {
            _supplyService = service; // Correct assignment
        }

        // Get all supplies
        [HttpGet]
        public async Task<ActionResult<SupplyReadDto>> GetSupplies([FromQuery] PaginationOptions paginationOptions)
        {
            var paginatedSupplies = await _supplyService.GetAllAsync(paginationOptions);
             return Ok(paginatedSupplies);
        }

        

        // Get supply by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplyReadDto>> GetSupplyById(Guid id)
        {
            var supplyItem = await _supplyService.GetByIdAsync(id);
            if (supplyItem == null)
            {
                return NotFound();
            }
            return Ok(supplyItem);
        }

        // Create a new supply
        
        [HttpPost]
        public async Task<ActionResult<SupplyReadDto>> CreateOne(SupplyCreateDto createDto)
       {
          var supplyCreated = await _supplyService.CreateOneAsync(createDto);
           return Created($"api/v1/supplies/{supplyCreated.SupplyId}", supplyCreated);
       }

         
     
        // Update supply
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSupply(Guid id, SupplyUpdateDto updateDto) // Use SupplyUpdateDto
        {
            var isUpdated = await _supplyService.UpdateOnAsync(id, updateDto);
            if (!isUpdated)
            {
                return NotFound();
            }
            return NoContent();
        }

        // Delete supply
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSupply(Guid id)
        {
            var isDeleted = await _supplyService.DeleteOneAsync(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
