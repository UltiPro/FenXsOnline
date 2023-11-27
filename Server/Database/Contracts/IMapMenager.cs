using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMapMenager
{
    Task<MapDataResponse> Get(int id);
    Task<List<MapHero>> GetMapHeroes();
    Task<bool> DropItem(int accountId, int itemId);
    Task<bool> GrabItem(int accountId);
}
