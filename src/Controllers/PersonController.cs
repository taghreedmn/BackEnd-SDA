using FusionTech.Service.Person;
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

        [HttpGet]
        public async Task<ActionResult<PersonReadDto>> GetPerson([FromQuery] int id)
        {
            var person = await _personService.GetByIdAsync(id);
            return Ok(person); // 200
        }
    }
}
