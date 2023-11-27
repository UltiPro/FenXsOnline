using Classes.Models.Game.Map;

namespace Classes.Models.Game;

public sealed class World
{
    private static World _world;

    public readonly List<MapData> Maps = new List<MapData>();
    private readonly bool x = false;
    private readonly bool o = true;

    private World()
    {
        Maps.Add(new MapData
        {
            Id = 0,
            Name = "Home",
            SpriteURL = "",
            IsPvP = false,
            Fields = new bool[11, 13]
            {
                {x, x, x, x, x, x, x, x, x, x, x, x, x },
                {x, x, x, x, x, x, x, x, x, x, x, x, x },
                {x, x, x, x, x, x, x, x, x, x, x, x, x },
                {x, x, o, o, x, o, o, o, o, o, o, o, x },
                {x, o, o, o, o, x, o, o, x, x, x, x, x },
                {x, o, o, o, x, x, o, o, x, x, x, x, x },
                {x, x, o, o, x, x, o, o, o, x, x, x, x },
                {x, x, o, o, o, o, o, o, o, o, o, o, x },
                {x, x, o, o, o, o, o, o, o, o, o, o, x },
                {x, x, x, x, x, x, x, o, o, x, x, x, x },
                {x, x, x, x, x, x, x, x, x, x, x, x, x }
            },
            Doors = new List<MapDoor>
            {
                new MapDoor{
                    FromX = 7,
                    FromY = 9,
                    ToMapId = 1,
                    ToX = 1,
                    ToY = 1
                },
                new MapDoor{
                    FromX = 8,
                    FromY = 9,
                    ToMapId = 1,
                    ToX = 1,
                    ToY = 1
                }
            }
        });
    }

    public static World GetInstance()
    {
        if (_world == null)
            _world = new World();

        return _world;
    }
}
