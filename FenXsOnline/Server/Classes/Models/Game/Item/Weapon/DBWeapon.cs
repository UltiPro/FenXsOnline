using Classes.Enums.Game;

namespace Classes.Models.Game.Item.Weapon;

public class DBWeapon : BaseItemWeapon
{
    public ItemType ItemType { get; set; } = ItemType.Weapon;
}
