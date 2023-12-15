using Classes.Models.Game.Item;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Mob;

public class DBMobDrop : ItemProvider
{
    [JsonIgnore]
    public int MobId { get; set; }
    [ForeignKey("MobId")]
    [JsonIgnore]
    public DBMob DBMob { get; set; }
}
