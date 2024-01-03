using Classes.Models.Game.Quest;

namespace Database.Contracts;

public interface IQuestMenager
{
    Task TakeQuest(string accountId, int questId);
    Task<List<QuestStageResponse>> GetQuestsInfo(string accountId);
    Task DoQuest(string accountId, int questId);
}
