using Classes.Models.Game.Map;

namespace Database.Contracts;

public interface IMapMenager
{
    Task<MapDataResponse> Get(int id);
}
