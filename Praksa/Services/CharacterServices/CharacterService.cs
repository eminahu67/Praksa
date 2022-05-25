using Praksa.Dtos.Character;
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
            characters.Add(_mapper.Map<Character>(newCharacter));
            ServiceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(Character newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(newCharacter);
            ServiceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return ServiceResponse;
        }

        public Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDto>();
           ServiceResponse.Data = _mapper.Map<GetCharacterDto> (characters.FirstOrDefault(c => c.Id == id));
            return ServiceResponse;
        }
    }
}

