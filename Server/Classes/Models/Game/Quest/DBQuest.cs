namespace Classes.Models.Game.Quest;

public class DBQuest
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int NpcId { get; set; }
    public string NpcMessage { get; set; }
    public int Level { get; set; } = 1;
    public int Gold { get; set; } = 0;
    public ICollection<DBQuestStage> Stages { get; set; }
    public ICollection<DBQuestReward>? Rewards { get; set; } = null;
}
