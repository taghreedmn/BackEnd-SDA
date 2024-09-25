//This Controller will do:
//1-Create Console
//2-update Console
//3-get Console by id
//4-get all Consoles
//5-delete all Consoles
//6-delete Console by id

using System.Collections.Generic;
using System.Linq;
using FusionTech.src.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ConsoleController : ControllerBase
    {
        public static List<GameConsole> consoles = new List<GameConsole>
        {
            new GameConsole { ConsoleId = 508, ConsoleName = "PlayStation 5" },
            new GameConsole { ConsoleId = 340, ConsoleName = "Steam Deck" },
            new GameConsole { ConsoleId = 933, ConsoleName = "Atari 2600" },
        };

        //1-Create Console:
        [HttpPost]
        public ActionResult CreateConsole(GameConsole NewConsole)
        {
            consoles.Add(NewConsole);
            //return Ok("New Console added !");
            return CreatedAtAction(
                nameof(GetConsoleById),
                new { id = NewConsole.ConsoleId },
                NewConsole
            );
        }

        //2-update Console
        [HttpPut("{id}")]
        public ActionResult UpdateConsole(GameConsole updatedConsole, int id)
        {
            GameConsole? foundConsole = consoles.FirstOrDefault(console => console.ConsoleId == id);

            // if not fount
            if (foundConsole == null)
            {
                return NotFound();
            }
            //if found
            foundConsole.ConsoleName = updatedConsole.ConsoleName;
            //return Ok();
            return CreatedAtAction(
                nameof(GetConsoleById),
                new { id = updatedConsole.ConsoleId },
                updatedConsole
            );
        }

        //3-get Console by id
        [HttpGet("{id}")]
        public ActionResult GetConsoleById(int id)
        {
            GameConsole? foundConsole = consoles.FirstOrDefault(console => console.ConsoleId == id);

            // if not fount
            if (foundConsole == null)
            {
                return NotFound();
            }
            //if found
            return Ok(foundConsole);
        }

        //4-get all Consoles
        [HttpGet]
        public ActionResult GetConsoles()
        {
            return Ok(consoles);
        }

        //5-delete all Consoles
        [HttpDelete]
        public ActionResult DeleteAllConsoles()
        {
            consoles.Clear();
            return Ok();
        }

        //6-delete Console by id
        [HttpDelete("{id}")]
        public ActionResult DeleteConsoleById(int id)
        {
            GameConsole? foundConsole = consoles.FirstOrDefault(console => console.ConsoleId == id);

            // if not fount
            if (foundConsole == null)
            {
                return NotFound();
            }
            //if found
            consoles.Remove(foundConsole);
            return NoContent();
        }
    }
}
