using System.Text.Json.Serialization;

namespace Classes.Models.Game.Map;

public class DBMapMob
{
    [JsonIgnore]
    public int MapId { get; set; }
    public int MobId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
}
