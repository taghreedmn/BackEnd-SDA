using FusionTech.src.DTO;
using FusionTech.src.Utils;
using FusionTech.videoGameVersion;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.VideoGameVersionDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class VideoGamesVersionController : ControllerBase
    {
        protected readonly IVideoGameVersionService _versionService;

        public VideoGamesVersionController(IVideoGameVersionService videoGameVersionService)
        {
            _versionService = videoGameVersionService;
        }

        [HttpPost]
        public async Task<ActionResult<VideoGameVersionReadDto>> CreateOne(
            [FromBody] VideoGameVersionCreateDto createDto
        )
        {
            var videoGameVersionCreated = await _versionService.CreateOneAsync(createDto);
            return Created($"api/v1/categories/{videoGameVersionCreated.Id}", videoGameVersionCreated);
            // return Ok(categoryCreated);
        }

        [HttpGet]
        public async Task<ActionResult<VideoGameVersionReadDto>> GetVersion(

        )
        {
            var versionList = await _versionService.GetAllAsync();
            return Ok(versionList);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<VideoGameVersionReadDto>> GetVersionByIdAsync([FromRoute] Guid Id)
        {
            var version = await _versionService.GetVersionByIdAsync(Id);
            return Ok(version);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<VideoGameVersionReadDto>> DeleteOneAsync([FromRoute] Guid Id)
        {
            var version = await _versionService.GetVersionByIdAsync(Id);
            if (version == null)
            {
                return NotFound();
            }
            await _versionService.DeleteOneAsync(version.Id);
            return Ok(version);
        }

        //         [HttpPut("{Id}")]
        //         public ActionResult PutCategory(Guid id, Category updateCategory)
        //         {
        //             Category? foundCategory = categories.FirstOrDefault(c => c.Id == id);
        //             if (foundCategory == null)
        //             {
        //                 return NotFound();
        //             }

        //             foundCategory.Id = updateCategory.Id;
        //             foundCategory.CategoryName = updateCategory.CategoryName;
        //             return NoContent();
        //         }
    }
}