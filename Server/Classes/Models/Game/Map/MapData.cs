using Classes.Models.Game.Npc;

namespace Classes.Models.Game.Map;

public class MapData : MapDataRefresh
{
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsPvP { get; set; }
    public bool[,] Fields { get; set; }
    public List<MapDoor>? Doors { get; set; } = null;
    public List<DBNpc>? NPCs { get; set; } = null;
}
