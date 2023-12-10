namespace Classes.Models.Game.Map.Instance;

public class Map0 : MapFieldsHelper
{
    public static MapData Get()
    {
        return new MapData
        {
            Name = "Home",
            SpriteURL = "home.png",
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
            Doors = new List<MapDoor>{
                new MapDoor{
                    X = 7,
                    Y = 9,
                    ToMapId = 1,
                    ToX = 1,
                    ToY = 1
                },
                new MapDoor{
                    X = 8,
                    Y = 9,
                    ToMapId = 1,
                    ToX = 1,
                    ToY = 1
                }
            }
        };
    }
}
