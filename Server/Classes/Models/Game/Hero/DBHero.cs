using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;
using Classes.Models.User;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Hero;

public class DBHero : HeroBasicInfo
{
    public int Atack { get; set; } = 0;
    public int MagicAtack { get; set; } = 0;
    public int CriticalChance { get; set; } = 0;
    public int Armor { get; set; } = 0;
    public int MagicArmor { get; set; } = 0;
    public int Agility { get; set; } = 0;
    public int Weight { get; set; } = 0;
    public int Gold { get; set; } = 0;
    public int MapId { get; set; } = 0;
    public int X { get; set; } = 2;
    public int Y { get; set; } = 4;
    [JsonIgnore]
    public bool InGame { get; set; } = false;
    public DateTime? Dead { get; set; } = null;

    [JsonIgnore]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    [JsonIgnore]
    public DBUser DBUser { get; set; }

    [JsonIgnore]
    public int? ArmorId { get; set; } = null;
    [ForeignKey("ArmorId")]
    public DBArmor? DBArmor { get; set; } = null;

    [JsonIgnore]
    public int? BootsId { get; set; } = null;
    [ForeignKey("BootsId")]
    public DBBoots? DBBoots { get; set; } = null;

    [JsonIgnore]
    public int? GlovesId { get; set; } = null;
    [ForeignKey("GlovesId")]
    public DBGloves? DBGloves { get; set; } = null;

    [JsonIgnore]
    public int? HelmetId { get; set; } = null;
    [ForeignKey("HelmetId")]
    public DBHelmet? DBHelmet { get; set; } = null;

    [JsonIgnore]
    public int? NecklaceId { get; set; } = null;
    [ForeignKey("NecklaceId")]
    public DBNecklace? DBNecklace { get; set; } = null;

    [JsonIgnore]
    public int? RingId { get; set; } = null;
    [ForeignKey("RingId")]
    public DBRing? DBRing { get; set; } = null;

    [JsonIgnore]
    public int? SecondaryWeaponId { get; set; } = null;
    [ForeignKey("SecondaryWeaponId")]
    public DBSecondaryWeapon? DBSecondaryWeapon { get; set; } = null;

    [JsonIgnore]
    public int? WeaponId { get; set; } = null;
    [ForeignKey("WeaponId")]
    public DBWeapon? DBWeapon { get; set; } = null;
}
