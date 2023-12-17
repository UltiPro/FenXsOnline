using Classes.Models.Game.Item;
using System.Text.Json.Serialization;

namespace Classes.Models.Game.Map;

public class DBMapItem : ItemProvider
{
    [JsonIgnore]
    public int MapId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public DateTime? Available { get; set; } = null;
}
