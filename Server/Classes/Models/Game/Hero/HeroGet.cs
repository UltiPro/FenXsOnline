using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;

namespace Classes.Models.Game.Hero;

public class HeroGet : HeroBasicInfo
{
    public int Atack { get; set; }
    public int MagicAtack { get; set; }
    public int CriticalChance { get; set; }
    public int Armor { get; set; }
    public int MagicArmor { get; set; }
    public int Agility { get; set; }
    public int Weight { get; set; }
    public int Gold { get; set; }
    public int MapId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsDead { get; set; }
    public DBArmor? DBArmor { get; set; }
    public DBBoots? DBBoots { get; set; }
    public DBGloves? DBGloves { get; set; }
    public DBHelmet? DBHelmet { get; set; }
    public DBNecklace? DBNecklace { get; set; }
    public DBRing? DBRing { get; set; }
    public DBSecondaryWeapon? DBSecondaryWeapon { get; set; }
    public DBWeapon? DBWeapon { get; set; }
}
