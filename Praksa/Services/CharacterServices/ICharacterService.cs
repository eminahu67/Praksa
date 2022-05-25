using System.Collections.Generic;
using Praksa.Models;
using System.Threading.Tasks;

namespace Praksa.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);


    }
}
