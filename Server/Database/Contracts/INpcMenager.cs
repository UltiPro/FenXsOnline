using Classes.Models.Game.Hero;

namespace Database.Contracts;

public interface INpcMenager
{
    Task<bool> Heal(string accountId, int npcId);
    Task<int> Sell(string accountId, int npcId, int itemId);
    Task<DBHeroEquipment> Buy(string accountId, int npcId, int itemId);
}
