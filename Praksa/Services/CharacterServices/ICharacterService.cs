using System.Collections.Generic;
using Praksa.Models;
using System.Threading.Tasks;
using Praksa.Dtos.Character;

namespace Praksa.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);


    }
}
