using Classes.Models.Game.Hero;
using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMapMenager
{
    Task<MapDataResponse> Get(string accountId);
    Task<MapDataRefresh> GetRefresh(string accountId);
    Task<DBMapItem> DropItem(string accountId, int itemId);
    Task<DBHeroEquipment> GrabItem(string accountId);
}
