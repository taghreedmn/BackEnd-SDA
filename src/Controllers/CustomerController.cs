using FusionTech.Service.CustomerService;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.CustomerDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        protected readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerReadDto>> CreateOne(CustomerCreateDto createDto)
        {
            var personCreated = await _customerService.CreateOneAsync(createDto);
            return Ok(personCreated);
        }
    }
}
