using Microsoft.AspNetCore.Mvc;
using Praksa.Models;
using System.Collections.Generic;
using System.Linq;
using Praksa.Services.CharacterServices;

namespace Praksa.Controllers;

[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
    

    public ICharacterService characterService { get; }

    public CharacterController( ICharacterService characterService)
    {
        this.characterService = characterService;
    }

    [HttpGet]
    [Route("GetAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(this.characterService.GetAllCharacters());
    }
    [HttpGet("{id}")]

    public ActionResult<Character> GetSingle(int id)
    {
        return Ok(this.characterService.GetCharacterById(id));
    }
    [HttpPost]
    public ActionResult<List<Character>> AddCharacter(Character newCharacter)
    {
        
        return Ok(characterService.AddCharacter(newCharacter));


    }
      

}




