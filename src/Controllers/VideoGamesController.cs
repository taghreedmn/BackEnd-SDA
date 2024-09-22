using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VideoGamesController : ControllerBase
    {
        public List<VideoGame> videoGames = new List<VideoGame>()
           {
            new VideoGame{Id = 1,Game_Name ="game1",Price =100,Description="description for game1",Year_of_release=new DateTime(2019, 7, 4),Rating=3,Company_ID=1},
            new VideoGame{Id = 2,Game_Name ="game2",Price =150,Description="description for game2",Year_of_release=new DateTime(2020, 9, 8),Rating=5,Company_ID=2},
            new VideoGame{Id = 3,Game_Name ="game3",Price =140,Description="description for game3",Year_of_release=new DateTime(2023, 3, 2),Rating=2,Company_ID=3},

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
            VideoGame? foundVideoGame = videoGames.FirstOrDefault(p => p.Id == id);
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
            return CreatedAtAction(nameof(GetVideoGameById), new { id = newVideoGame.Id }, newVideoGame);

        }

        // delete videoGame 

        [HttpDelete("{id}")]
        public ActionResult DeleteVideoGame(int id)
        {
            VideoGame? foundVideoGame = videoGames.FirstOrDefault(p => p.Id == id);
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

            VideoGame? foundVideoGame = videoGames.FirstOrDefault(p => p.Id == id);

            if (foundVideoGame == null)
            {
                return NotFound();
            }

            foundVideoGame.Game_Name = updatedVideoGame.Game_Name;
            foundVideoGame.Price = updatedVideoGame.Price;
            foundVideoGame.Description = updatedVideoGame.Description;
            foundVideoGame.Year_of_release = updatedVideoGame.Year_of_release;
            foundVideoGame.Rating = updatedVideoGame.Rating;
            foundVideoGame.Company_ID = updatedVideoGame.Company_ID;

            return NoContent();
        }
    }
}