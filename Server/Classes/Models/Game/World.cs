using Classes.Models.Game.Map;
using Classes.Models.Game.Map.Instance;

namespace Classes.Models.Game;

public sealed class World
{
    private static World _world;

    public readonly List<MapData> Maps = new List<MapData>();

    private World()
    {
        Maps.Add(Map0.Get());
        Maps.Add(Map1.Get());
        Maps.Add(Map2.Get());
        Maps.Add(Map3.Get());
    }

    public static World GetInstance()
    {
        if (_world == null)
            _world = new World();

        return _world;
    }
}
