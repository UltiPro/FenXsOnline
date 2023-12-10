using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map;

public class MapDataRefresh
{
    public List<MapMob>? Mobs { get; set; } = null;
    public List<ItemProviderGround>? Items { get; set; } = null;
    public List<MapHero>? Heroes { get; set; } = null;
}
