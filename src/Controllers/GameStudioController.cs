
//This Controller will do:
//1-Create Studio
//2-update Studio
//3-get Studio by id
//4-get all Studios
//5-delete all Studios
//6-delete Studio by id

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FusionTech.src.Entity;
using System.Linq;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class GameStudioController : ControllerBase
    {
        public static List<GameStudio> studios = new List<GameStudio>
        {
            new GameStudio { StudioId  = 508, StudioName = "GameSphere Studios" ,StudioPicturePath =""},
            new GameStudio { StudioId  = 340, StudioName = "Pixel Playhouse",StudioPicturePath = ""},
            new GameStudio { StudioId  = 933, StudioName = "GameGlow Studios" ,StudioPicturePath =""},
        };


        //1-Create Studio:

        [HttpPost]
        public ActionResult CreateStudio(GameStudio NewStudio)
        {
            studios.Add(NewStudio);
            //return Ok("New Studio added !");
              return CreatedAtAction(
                nameof(GetStudioById),
                new { id = NewStudio.StudioId },
                NewStudio
            );
        }

        //2-update Studio:
        [HttpPut("{id}")]
        public ActionResult UpdateStudio(GameStudio updatedStudio, int id)
        {
            GameStudio? foundSudio = studios.FirstOrDefault(studio => studio .StudioId== id);

            // if not fount
            if (foundSudio == null)
            {
                return NotFound();
            }
            //if found
            foundSudio.StudioName = updatedStudio.StudioName;
            return Ok(updatedStudio);
        }

        //3-get Studio by id
        [HttpGet("{id}")]
        public ActionResult GetStudioById(int id)
        {
            GameStudio? foundSudio= studios.FirstOrDefault(studio => studio.StudioId== id);

            // if not fount
            if (foundSudio == null)
            {
                return NotFound();
            }
            //if found
            return Ok(foundSudio);
        }

    

        //4-get all Studios
        [HttpGet]
        public ActionResult GetStudios()
        {
            return Ok(studios);
        }

        //5-delete all Studios
        [HttpDelete]
        public ActionResult DeleteAllStudios()
        {
            studios.Clear();
            return Ok();
        }

        //6-delete Studio by id
        [HttpDelete("{id}")]
        public ActionResult DeleteStudioById(int id)
        {
            GameStudio? foundSudio= studios.FirstOrDefault(studio => studio .StudioId== id);

            // if not fount
            if (foundSudio== null)
            {
                return NotFound();
            }
            //if found
            studios.Remove(foundSudio);
            return NoContent();
            
        }
    }
}