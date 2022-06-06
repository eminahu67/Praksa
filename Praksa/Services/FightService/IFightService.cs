using System.Collections.Generic;
using System.Threading.Tasks;
using Praksa.Dtos.Fight;
using Praksa.Dtos.Fight;
using Praksa.Models;

namespace Praksa.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}