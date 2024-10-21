using Classes.Models.Game.Hero;
using Classes.Models.Game.Npc;

namespace Database.Contracts;

public interface INpcMenager
{
    Task Heal(string accountId, int npcId);
    Task<int> Sell(string accountId, int npcId, int itemId);
    Task<DBHeroEquipment> Buy(string accountId, int npcId, int itemId);
    Task<DBNpc> GetNpc(DBHero hero, int npcId);
}
