using System.Collections.Generic;
using Praksa.Models;
using System.Threading.Tasks;

namespace Praksa.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task <List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task <List<Character>> AddCharacter(Character newCharacter);


    }
}
