using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map;

public class MapDataRefresh
{
    public List<MapMob>? Mobs { get; set; } = null;
    public List<ItemProviderTimer>? Items { get; set; } = null;
    public List<ItemProvider>? Dropped_Items { get; set; } = null;
    public List<MapHero>? Heroes { get; set; } = null;
}
