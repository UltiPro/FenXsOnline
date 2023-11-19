using Classes.Enums.Game;

namespace Classes.Models.Game.Item.Helmet;

public class DBHelmet : BaseItemArmor
{
    public ItemType ItemType { get; set; } = ItemType.Helmet;
}
