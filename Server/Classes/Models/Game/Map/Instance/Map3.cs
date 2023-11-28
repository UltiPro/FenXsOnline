using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map.Instance;

public class Map3 : MapFieldsHelper
{
    public static MapData Get()
    {
        return new MapData
        {
            Id = 0,
            Name = "",
            SpriteURL = "",
            IsPvP = false,
            Fields = new bool[,]
            {

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