using System.Text.Json.Serialization;

namespace Classes.Models.Game.Npc;

public class DBNpc
{
    public int Id { get; set; }
    [JsonIgnore]
    public int MapId { get; set; }
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsHealer { get; set; } = false;
    public bool IsTrader { get; set; } = false;
    public double PricePercent { get; set; } = 0.25;
    public ICollection<DBNpcShopItem>? ShopItems { get; set; } = null;
}
