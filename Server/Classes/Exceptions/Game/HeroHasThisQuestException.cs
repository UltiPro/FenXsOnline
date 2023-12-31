namespace Classes.Exceptions.Game;

public class HeroHasThisQuestException : Exception
{
    public HeroHasThisQuestException() : base("The hero has completed or is in the process of completing this quest.") { }
}
