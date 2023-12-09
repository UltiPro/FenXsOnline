using Classes.Models.Game.Hero;
using Classes.Models.Game.Item;
using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMapMenager
{
    Task<MapData> Get(string accountId);
    Task<MapDataRefresh> GetRefresh(string accountId);
    Task<ItemProviderGround> DropItem(string accountId, int itemId);
    Task<DBHeroEquipment> GrabItem(string accountId);
}
