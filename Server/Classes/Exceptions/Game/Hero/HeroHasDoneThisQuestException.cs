namespace Classes.Exceptions.Game.Hero;

public class HeroHasDoneThisQuestException : Exception
{
    public HeroHasDoneThisQuestException() : base("Hero has done this quest already.") { }
}
