namespace Classes.Models.Game.Map.Instance;

public class Map2 : MapFieldsHelper
{
    public static MapData Get()
    {
        return new MapData
        {
            Name = "Near Cave",
            SpriteURL = "nearcave.png",
            IsPvP = true,
            Fields = new bool[32, 32]
            {
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, o, o, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, o, o, o, x, x, x, x, o, o, o, o, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, o, o, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x},
                {x, x, x, o, o, o, x, x, o, x, x, x, x, x, x, x, o, o, o, o, x, x, o, o, o, o, o, x, x, x, x, x},
                {x, x, o, o, o, o, x, x, o, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, o, x, o, o, x, x, x, x},
                {x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x},
                {x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, o, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, o, o, o, x, o, o, o, o, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, o, o, x, o, o, x, o, x, o, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x},
                {x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x},
                {x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x},
                {x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x},
                {x, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x},
                {x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x}
            },
            Doors = new List<MapDoor>
            {
                new MapDoor
                {
                    X = 14,
                    Y = 28,
                    ToMapId = 1,
                    ToX = 35,
                    ToY = 86
                }
            }
        };
    }
}
