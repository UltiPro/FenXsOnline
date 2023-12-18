namespace Classes.Models.Game.Map;

public class MapDataRefresh
{
    public List<DBMapMob> Mobs { get; set; }
    public List<DBMapItem> Items { get; set; }
    public List<MapHero> Heroes { get; set; }
}
