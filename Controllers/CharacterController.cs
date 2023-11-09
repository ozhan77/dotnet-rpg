using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> knight = new List<Character>(){
            new Character(),
            new Character{Name ="cüce"}
        };

        [HttpGet]
        public ActionResult<List<Character>> Get(){
            return Ok(knight);
        }
    }
}