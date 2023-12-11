namespace Classes.Exceptions.Game;

public class HeroIsTooFarAwayException : Exception
{
    public HeroIsTooFarAwayException() : base("Hero is too far away to do this action.") { }
}
