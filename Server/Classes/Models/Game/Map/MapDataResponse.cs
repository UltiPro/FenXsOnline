using Classes.Models.Game.Npc;

namespace Classes.Models.Game.Map;

public class MapDataResponse : MapDataRefresh
{
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsPvP { get; set; }
    public List<MapPosition>? Doors { get; set; } = null;
    public List<DBNpc>? NPCs { get; set; } = null;
}
