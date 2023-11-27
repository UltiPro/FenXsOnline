using Classes.Models.Game.Map;
using Database.Contracts;

namespace Database.Repository;

public class MapMenager : IMapMenager
{
    public Task<bool> DropItem(int accountId, int itemId)
    {
        throw new NotImplementedException();
    }

    public Task<MapDataResponse> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<MapHero>> GetMapHeroes()
    {
        throw new NotImplementedException();
    }

    public Task<bool> GrabItem(int accountId)
    {
        throw new NotImplementedException();
    }
}
