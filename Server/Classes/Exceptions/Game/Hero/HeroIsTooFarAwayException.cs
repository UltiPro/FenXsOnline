namespace Classes.Exceptions.Game.Hero;

public class HeroIsTooFarAwayException : Exception
{
    public HeroIsTooFarAwayException() : base("Hero is too far away to do this action.") { }
}
