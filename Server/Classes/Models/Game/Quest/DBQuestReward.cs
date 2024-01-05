using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Classes.Models.Game.Item;

namespace Classes.Models.Game.Quest;

public class DBQuestReward : ItemProvider
{
    [JsonIgnore]
    public int QuestId { get; set; }
    [ForeignKey("QuestId")]
    public DBQuest DBQuest { get; set; }
    public int Quantity { get; set; } = 1;
}
