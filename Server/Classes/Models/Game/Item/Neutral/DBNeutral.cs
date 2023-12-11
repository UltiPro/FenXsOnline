using Classes.Enums.Game;

namespace Classes.Models.Game.Item.Neutral;

public class DBNeutral : BaseItem
{
    public string Description { get; set; } = string.Empty;
    public ItemType ItemType { get; set; } = ItemType.Neutral;
}
