using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Teamwork.src.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Teamwork.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VideoGamesController : ControllerBase
    {
        public List<VideoGame> videoGames = new List<VideoGame>()
        {
            new VideoGame
            {
                GameId = 1,
                GameName = "game1",
                Price = 100,
                Description = "description for game1",
                YearOfRelease = new DateTime(2019, 7, 4),
                TotalRating = 3,
                PublisherId = 1,
            },
            new VideoGame
            {
                GameId = 2,
                GameName = "game2",
                Price = 150,
                Description = "description for game2",
                YearOfRelease = new DateTime(2020, 9, 8),
                TotalRating = 5,
                PublisherId = 2,
            },
            new VideoGame
            {
                GameId = 3,
                GameName = "game3",
                Price = 140,
                Description = "description for game3",
                YearOfRelease = new DateTime(2023, 3, 2),
                TotalRating = 2,
                PublisherId = 3,
            },
        };

        //get all videoGames
        [HttpGet]
        public ActionResult GetVideoGames()
        {
            return Ok(videoGames);
        }

        // get by ID
        [HttpGet("{id}")]
        public ActionResult GetVideoGameById(int id)
        {
            VideoGame? foundVideoGame = videoGames.FirstOrDefault(p => p.GameId == id);
            if (foundVideoGame == null)
            {
                return NotFound();
            }
            return Ok(foundVideoGame);
        }

        // add a new videoGame

        [HttpPost]
        public ActionResult CreateVideoGame(VideoGame newVideoGame)
        {
            videoGames.Add(newVideoGame);
            return CreatedAtAction(
                nameof(GetVideoGameById),
                new { id = newVideoGame.GameId },
                newVideoGame
            );
        }

        // delete videoGame

        [HttpDelete("{id}")]
        public ActionResult DeleteVideoGame(int id)
        {
            VideoGame? foundVideoGame = videoGames.FirstOrDefault(p => p.GameId == id);
            if (foundVideoGame == null)
            {
                return NotFound();
            }
            videoGames.Remove(foundVideoGame);
            return NoContent();
        }

        // update videoGame

        [HttpPut("{id}")]
        public ActionResult UpdateVideoGame(int id, VideoGame updatedVideoGame)
        {
            VideoGame? foundVideoGame = videoGames.FirstOrDefault(p => p.GameId == id);

            if (foundVideoGame == null)
            {
                return NotFound();
            }

            foundVideoGame.GameName = updatedVideoGame.GameName;
            foundVideoGame.Price = updatedVideoGame.Price;
            foundVideoGame.Description = updatedVideoGame.Description;
            foundVideoGame.YearOfRelease = updatedVideoGame.YearOfRelease;
            foundVideoGame.TotalRating = updatedVideoGame.TotalRating;
            foundVideoGame.PublisherId = updatedVideoGame.PublisherId;

            return NoContent();
        }
    }
}
