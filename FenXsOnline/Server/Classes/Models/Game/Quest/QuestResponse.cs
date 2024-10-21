namespace Classes.Models.Game.Quest;

public class QuestResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string NpcMessage { get; set; }
    public int Level { get; set; } = 1;
}
