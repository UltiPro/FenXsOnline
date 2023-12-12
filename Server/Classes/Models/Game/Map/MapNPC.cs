using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map;

public class MapNPC : MapPosition
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsHealer { get; set; } = false;
    public bool IsTrader { get; set; } = false;
    public double PricePercent { get; set; } = 0.25;
    public List<ItemProviderSlot>? Items { get; set; } = null;
}
