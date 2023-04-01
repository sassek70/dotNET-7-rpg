
using dotNET_7_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNET_7_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase 
    {
        private static List<Character> charactersList = new List<Character> {
            new Character(),
            new Character { CharacterName = "Sam"}
        };

        [HttpGet("/defaultCharacterList")]
        public ActionResult<Character> GetCharacterList()
        {
            return Ok(charactersList);
        }

        [HttpGet("/singleCharacter")]
        public ActionResult<Character> GetSingleCharacter()
        {
            return Ok(charactersList[0]);
        }
    }
}