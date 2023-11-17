using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;

namespace Classes.Models.Game.Hero;

public class DBHero : HeroBasicInfo
{
    public int Atack { get; set; } = 0;
    public int MagicAtack { get; set; } = 0;
    public int CriticalChance { get; set; } = 0;
    public int Armor { get; set; } = 1;
    public int MagicArmor { get; set; } = 0;
    public int Agility { get; set; } = 0;
    public int Weight { get; set; } = 1;
    public int Gold { get; set; } = 0;
    public int MapId { get; set; } = 0;
    public int X { get; set; } = 3;
    public int Y { get; set; } = 2;
    public DBArmor? armor { get; set; } = null;
    public DBBoots? boots { get; set; } = null;
    public DBGloves? gloves { get; set; } = null;
    public DBHelmet? helmet { get; set; } = null;
    public DBNecklace? necklace { get; set; } = null;
    public DBRing? ring { get; set; } = null;
    public DBSecondaryWeapon? secondaryWeapon { get; set; } = null;
    public DBWeapon? weapon { get; set; } = null;
}
