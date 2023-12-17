using Classes.Models.Game.Mob;

namespace Database.Contracts;

public interface IMobMenager
{
    Task<DBMob> Get(int id);
    Task<MobProvider> GetInfo(int id);
}
