using Classes.Models.Game.Hero;
using Classes.Models.Game.Quest;

namespace Database.Contracts;

public interface IQuestMenager
{
    Task TakeQuest(string accountId, int questId);
    Task<List<QuestStageResponse>> GetQuestsInfo(string accountId);
    Task<QuestCompletedResponse> TalkOrBring(string accountId, int questId);
    void Kill(DBHero hero, int mobId);
}
