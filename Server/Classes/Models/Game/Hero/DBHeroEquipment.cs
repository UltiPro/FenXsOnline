using Classes.Models.Game.Item;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Hero;

public class DBHeroEquipment : ItemProvider
{
    public int OrderId { get; set; }
    [JsonIgnore]
    public string HeroId { get; set; }
    [ForeignKey("HeroId")]
    [JsonIgnore]
    public DBHero DBHero { get; set; }
}
