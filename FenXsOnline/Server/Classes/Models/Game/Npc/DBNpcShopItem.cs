using Classes.Models.Game.Item;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Npc;

public class DBNpcShopItem : ItemProvider
{
    [JsonIgnore]
    public int NpcId { get; set; }
    [JsonIgnore]
    [ForeignKey("NpcId")]
    public DBNpc DBNpc { get; set; }
    public int Id { get; set; }
}
