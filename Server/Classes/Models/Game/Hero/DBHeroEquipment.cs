using Classes.Models.Game.Item;
using Classes.Models.User;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Hero;

public class DBHeroEquipment : ItemProvider
{
    public int OrderId { get; set; }
    [JsonIgnore]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    [JsonIgnore]
    public DBUser DBUser { get; set; }
}
