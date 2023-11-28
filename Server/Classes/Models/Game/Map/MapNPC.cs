using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map;

public class MapNPC : MapPosition
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsHealer { get; set; }
    public bool IsTrader { get; set; }
    public int? PricePercent { get; set; } = null;
    public List<ItemProvider>? Items { get; set; } = null;
}
