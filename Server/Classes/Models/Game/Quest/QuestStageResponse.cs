using System.Text.Json.Serialization;

namespace Classes.Models.Game.Quest;

public class QuestStageResponse
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
