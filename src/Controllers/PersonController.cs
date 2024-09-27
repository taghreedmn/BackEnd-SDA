using FusionTech.Service.PersonService;
using FusionTech.src.Entity;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.PersonDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PersonController : ControllerBase
    {
        protected readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonReadDto>> GetPerson(int id)
        {
            var person = await _personService.GetByIdAsync(id);
            return Ok(person); // 200
        }
    }
}
