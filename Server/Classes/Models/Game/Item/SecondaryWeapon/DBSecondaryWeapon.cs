using Classes.Enums.Game;

namespace Classes.Models.Game.Item.SecondaryWeapon;

public class DBSecondaryWeapon : BaseItemWeapon
{
    public ItemType ItemType { get; set; } = ItemType.SecondaryWeapon;
}
