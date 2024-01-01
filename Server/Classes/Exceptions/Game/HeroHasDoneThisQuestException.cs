namespace Classes.Exceptions.Game;

public class HeroHasDoneThisQuestException : Exception
{
    public HeroHasDoneThisQuestException() : base("Hero has done this quest already.") { }
}
