using Classes.Enums.Game;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Hero;

public class DBHeroEquipment
{
    [JsonIgnore]
    public int HeroId { get; set; }
    [ForeignKey("HeroId")]
    [JsonIgnore]
    public DBHero DBHero { get; set; }
    public int OrderId { get; set; }
    public ItemType? ItemType { get; set; } = null;
    public int? ItemId { get; set; } = null;
}
