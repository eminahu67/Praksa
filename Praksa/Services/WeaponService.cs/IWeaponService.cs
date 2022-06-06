using System.Threading.Tasks;
using Praksa.Dtos.Character;
using Praksa.Dtos.Character;
using Praksa.Dtos.Weapon;
using Praksa.Models;

namespace Praksa.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}