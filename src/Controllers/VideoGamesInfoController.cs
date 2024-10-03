using FusionTech.src.Entity;
using FusionTech.src.Services.VideoGamesInfo;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.VideoGameInfoDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VideoGamesInfoController : ControllerBase
    {
        private readonly IVideoGameInfoService _videoGameInfoService;

        public VideoGamesInfoController(IVideoGameInfoService videoGameInfoService)
        {
            _videoGameInfoService = videoGameInfoService;
        }

        // Get all video games
        [HttpGet]
        public async Task<IActionResult> GetVideoGames()
        {
            var videoGames = await _videoGameInfoService.GetAllAsync();
            return Ok(videoGames);
        }

        // Get by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVideoGameById(Guid id)
        {
            var videoGame = await _videoGameInfoService.GetByIdAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return Ok(videoGame);
        }

        // Add a new video game
        [HttpPost]
        public async Task<IActionResult> CreateVideoGame(VideoGameInfoCreateDto newVideoGameDto)
        {
            var createdVideoGame = await _videoGameInfoService.CreateOneAsync(newVideoGameDto);
            return CreatedAtAction(nameof(GetVideoGameById), new { id = createdVideoGame.GameId }, createdVideoGame);
        }

        // Delete video game
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(Guid id)
        {
            var isDeleted = await _videoGameInfoService.DeleteAsync(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }

        // Update video game
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVideoGame(Guid id, VideoGameInfoUpdateDto updatedVideoGameDto)
        {
            var isUpdated = await _videoGameInfoService.UpdateOnAsync(id, updatedVideoGameDto);
            if (!isUpdated)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

