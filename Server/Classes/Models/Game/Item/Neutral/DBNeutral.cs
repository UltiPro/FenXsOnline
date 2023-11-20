using Classes.Enums.Game;

namespace Classes.Models.Game.Item.Neutral;

public class DBNeutral
{
    public int Price { get; set; } = 0;
    public string Description { get; set; } = string.Empty;
    public ItemType ItemType { get; set; } = ItemType.Neutral;
}
