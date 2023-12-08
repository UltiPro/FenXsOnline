using Classes.Models.Game.Item;
using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMapMenager
{
    Task<MapData> Get(string accountId);
    Task<MapDataRefresh> GetRefresh(string accountId);
    Task DropItem(int accountId, int itemId);
    Task<ItemProvider> GrabItem(int accountId);
}
