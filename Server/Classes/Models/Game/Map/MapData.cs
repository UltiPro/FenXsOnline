using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map;

public class MapData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsPvP { get; set; }
    public bool[,] Fields { get; set; }
    public List<MapDoor>? Doors { get; set; } = null;
    public List<MapNPC>? NPCs { get; set; } = null;
    public List<MapMob>? Mobs { get; set; } = null;
    public List<ItemProviderTimer>? Items { get; set; } = null;
    public List<ItemProvider>? Dropped_Items { get; set; } = null;
}
