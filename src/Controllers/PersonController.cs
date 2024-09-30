using FusionTech.src.Services.Person;
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
        public async Task<ActionResult<PersonSignInDTO>> GetPerson([FromQuery] int id)
        {
            var person = await _personService.GetByIdAsync(id);
            return Ok(person); // 200
        }

        [HttpPost("signIn")]
        public async Task<ActionResult<string>> SignInPerson(
            [FromBody] PersonSignInDTO personSignInDTO
        )
        {
            var token = await _personService.SignInAsync(personSignInDTO);
            return Ok(token); // 200
        }
    }
}
