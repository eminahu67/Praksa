﻿using Praksa.Dtos.Character;
using Praksa.Models;
using System.Threading.Tasks;
using AutoMapper;

namespace Praksa.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character> {
new Character(),
new Character { Id = 1, Name = "Sam"}
    };


        private readonly IMapper _mapper;
        public CharacterService(IMapper  mapper)
        {
    
        _mapper = mapper;

    }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;
            characters.Add(character);
            ServiceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return ServiceResponse;
        }

      

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            //characters.Add(newCharacter);
            ServiceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return ServiceResponse;
        }


        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDto>();
           ServiceResponse.Data = _mapper.Map<GetCharacterDto> (characters.FirstOrDefault(c => c.Id == id));
            return ServiceResponse;
        }
    }
}

