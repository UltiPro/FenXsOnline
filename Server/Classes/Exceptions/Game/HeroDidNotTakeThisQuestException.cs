namespace Classes.Exceptions.Game;

public class HeroDidNotTakeThisQuestException : Exception
{
    public HeroDidNotTakeThisQuestException() : base("Hero did not take this quest.") { }
}
