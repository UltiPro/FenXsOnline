using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Classes.Enums.Game;

namespace Classes.Models.Game.Quest;

public class DBQuestStage
{
    [JsonIgnore]
    public int QuestId { get; set; }
    [ForeignKey("QuestId")]
    public DBQuest DBQuest { get; set; }
    [JsonIgnore]
    public int Stage { get; set; }
    public string Description { get; set; }
    public bool Talk { get; set; } = false;
    [JsonIgnore]
    public int? NpcId { get; set; } = null; // For talk and bring
    public string? NpcMessage { get; set; } = null;
    public string? NpcAnswear { get; set; } = null;
    public bool Kill { get; set; } = false;
    public int? MobId { get; set; } = null;
    public bool Bring { get; set; } = false;
    public ItemType? ItemType { get; set; } = null;
    public int? ItemId { get; set; } = null;
    public int? Quantity { get; set; } = null; // For kill and bring
}
