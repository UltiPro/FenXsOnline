using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map.Instance;

public class Map2 : MapFieldsHelper
{
    public static MapData Get()
    {
        return new MapData
        {
            Id = 0,
            Name = "Home",
            SpriteURL = "nearcave.png",
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

            },
            NPCs = new List<MapNPC> { },
            Mobs = new List<MapMob> { },
            Items = new List<ItemProviderTimer> { },
            Dropped_Items = new List<ItemProvider> { }
        };
    }
}