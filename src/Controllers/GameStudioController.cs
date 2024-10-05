//This Controller will do:
//1-Create Studio
//2-update Studio
//3-get Studio by id
//4-get all Studios
//5-delete Studio by id

using FusionTech.src.Services.Studio;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.StudioDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GameStudioController : ControllerBase
    {
        protected readonly IStudioService _studioService;

        public GameStudioController(IStudioService studioService)
        {
            _studioService = studioService;
        }

        //1-Create Studio:

        [HttpPost]
        public async Task<ActionResult<ReadStudioDTO>> CreateOneAsync(CreatStudioDTO createDTO)
        {
            var studioCreated = await _studioService.CreateOneAsync(createDTO);
            return Created($"api/v1/GameStudio/{studioCreated.StudioName}", studioCreated);
        }

        //2-update Studio:
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> UpdateAsync(Guid id, UpdateStudioDTO studioName)
        {
            var updated = await _studioService.UpdateAsync(id, studioName);
            if (!updated)
            {
                return NotFound();
            }
            return NoContent();
        }

        //3-get Studio by id
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadStudioDTO>> GetIdAsync(Guid id)
        {
            var foundstudio = await _studioService.GetIdAsync(id);
            return Ok(foundstudio);
        }

        //4-get all Studios
        [HttpGet]
        public async Task<ActionResult<ReadStudioDTO>> GetAllAsync()
        {
            var Liststudio = await _studioService.GetAllAsync();
            return Ok(Liststudio);
        }

        //5-delete Studio by id
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteId(Guid id)
        {
            var foundSudio = await _studioService.GetIdAsync(id);

            // if not fount
            if (foundSudio == null)
            {
                return NotFound();
            }
            //if found
            await _studioService.DeleteIdAsync(foundSudio.GameStudioId);
            return NoContent();
        }
    }
}