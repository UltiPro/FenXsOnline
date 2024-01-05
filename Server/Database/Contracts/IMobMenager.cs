using Classes.Models.Game.Mob;

namespace Database.Contracts;

public interface IMobMenager
{
    Task<MobProvider> GetInfo(int id);
}
