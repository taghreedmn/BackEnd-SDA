using System.Security.Claims;
using FusionTech.src.Entity;
using FusionTech.src.Services.VideoGamesInfo;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Policy = "admin")]
        // Add a new video game
        [HttpPost]
        public async Task<IActionResult> CreateVideoGame(VideoGameInfoCreateDto newVideoGameDto)
        {
            string? userEmail = User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(userEmail))
            {
                return Unauthorized("User email not found");
            }

            var createdVideoGame = await _videoGameInfoService.CreateOneAsync(newVideoGameDto,userEmail);
            if (createdVideoGame == null)
            {
                return BadRequest("Failed to create video game");
            }

            return CreatedAtAction(nameof(GetVideoGameById), new { id = createdVideoGame.GameId }, createdVideoGame);
        }

        [Authorize(Policy = "admin")]
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

        [Authorize(Policy = "admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGameName(Guid id, string newGameName)
        {
            var isUpdated = await _videoGameInfoService.UpdateGameNameAsync(id, newGameName);

            if (!isUpdated)
            {
                return NotFound("Video game not found or update failed.");
            }

            return NoContent();
        }

        [Authorize(Policy = "admin")]
        [HttpPut("{id}/year")]
        public async Task<IActionResult> UpdateYearOfRelease(Guid id, string newYearOfRelease)
        {
            var isUpdated = await _videoGameInfoService.UpdateYearOfReleaseAsync(id, newYearOfRelease);

            if (!isUpdated)
            {
                return NotFound("Video game not found or update failed.");
            }

            return NoContent();
        }
    }
}
