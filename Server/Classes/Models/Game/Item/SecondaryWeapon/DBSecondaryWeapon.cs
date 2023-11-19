using Classes.Enums.Game;

namespace Classes.Models.Game.Item.SecondaryWeapon;

public class DBSecondaryWeapon : BaseItemWeapon
{
    public int Armor { get; set; } = 0;
    public int MagicArmor { get; set; } = 0;
    public ItemType ItemType { get; set; } = ItemType.SecondaryWeapon;
}
