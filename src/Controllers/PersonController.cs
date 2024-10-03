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
