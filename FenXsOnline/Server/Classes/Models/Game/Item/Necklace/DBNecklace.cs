using Classes.Enums.Game;

namespace Classes.Models.Game.Item.Necklace;

public class DBNecklace : BaseItemJewelry
{
    public ItemType ItemType { get; set; } = ItemType.Necklace;
}
