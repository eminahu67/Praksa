using System.Collections.Generic;
using Praksa.Models;

namespace Praksa.Services.CharacterServices
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);


    }
}
