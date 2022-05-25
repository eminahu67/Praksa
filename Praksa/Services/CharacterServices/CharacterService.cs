using Praksa.Models;
using System.Threading.Tasks;

namespace Praksa.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character> {
new Character(),
new Character { Id = 1, Name = "Sam"}
    };
        private readonly Character newCharacter;

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            ServiceResponse.Data = characters;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            ServiceResponse.Data = characters;
            return ServiceResponse;
            
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<Character>();
           ServiceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
            return ServiceResponse;
        }
    }
}

