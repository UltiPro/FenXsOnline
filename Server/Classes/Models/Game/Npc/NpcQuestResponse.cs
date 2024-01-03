using Classes.Models.Game.Quest;

namespace Classes.Models.Game.Npc;

public class NpcQuestResponse : DBNpc
{
    public List<QuestResponse> Quests { get; set; }
}
