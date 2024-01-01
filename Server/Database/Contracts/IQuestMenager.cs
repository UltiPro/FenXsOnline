namespace Database.Contracts;

public interface IQuestMenager
{
    Task TakeQuest(string accountId, int questId);
}
