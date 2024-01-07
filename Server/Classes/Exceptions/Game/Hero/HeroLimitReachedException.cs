namespace Classes.Exceptions.Game.Hero;

public class HeroLimitReachedException : Exception
{
    public HeroLimitReachedException() : base("Your account already has the maximum number of heroes.") { }
}
