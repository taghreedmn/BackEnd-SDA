//This Controller will do:
//1-Create Console
//2-update Console
//3-get Console by id
//4-get all Consoles
//5-delete Console by id

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ConsoleController : ControllerBase
    {
        protected readonly IConsoleService _consoleService;

        public ConsoleController(IConsoleService consoleService)
        {
            _consoleService = consoleService;
        }

        //1-Create Console:
        [Authorize(Policy = "EmployeeOrAdmin")]
        [HttpPost]
        public async Task<ActionResult<ConsoleReadDTO>> CreateOneAsync(ConsoleCreateDto createDTO)
        {
            var consoleCreated = await _consoleService.CreateOneAsync(createDTO);
            return Created($"api/v1/Console/{consoleCreated.ConsoleName}", consoleCreated);
        }

        //2-update Console
        [Authorize(Policy = "EmployeeOrAdmin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> UpdateAsync(Guid id, ConsoleUpdateDTO consoleName)
        {
            await _consoleService.UpdateAsync(id, consoleName);
            return NoContent();
        }

        //3-get Console by id
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsoleReadDTO>> GetIdAsync(Guid id)
        {
            var foundcosole = await _consoleService.GetIdAsync(id);
            return Ok(foundcosole);
        }

        //4-get all Consoles
        [HttpGet]
        public async Task<ActionResult<ConsoleReadDTO>> GetAllAsync()
        {
            var Listconsole = await _consoleService.GetAllAsync();
            return Ok(Listconsole);
        }

        //5-delete Console by id
        [Authorize(Policy = "EmployeeOrAdmin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteId(Guid id)
        {
            var foundConsole = await _consoleService.GetIdAsync(id);

            await _consoleService.DeleteIdAsync(foundConsole.GameConsoleId);
            return NoContent();
        }
    }
}
