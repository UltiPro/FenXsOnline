using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Classes.Enums.Game;

namespace Classes.Models.Game.Quest;

public class DBQuestReward
{
    [JsonIgnore]
    public int QuestId { get; set; }
    [ForeignKey("QuestId")]
    public DBQuest DBQuest { get; set; }
    public ItemType ItemType { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; } = 1;
}
