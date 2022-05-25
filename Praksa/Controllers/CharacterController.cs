﻿using Microsoft.AspNetCore.Mvc;
using Praksa.Models;
using System.Collections.Generic;
using System.Linq;
using Praksa.Services.CharacterServices;
using System.Threading.Tasks;

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
    public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
    {
        return Ok(await characterService.GetAllCharacters());
    }
    [HttpGet("{id}")]

    public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
    {
        return Ok(await characterService.GetCharacterById(id));
    }
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
    {
        
        return Ok(await characterService.AddCharacter(newCharacter));


    }
      

}




