using Classes.Models.Game.Fight;

namespace Database.Contracts;

public interface IFightMenager
{
    Task<FightMobResponse> FightMob(string accountId, int x, int y);
}
