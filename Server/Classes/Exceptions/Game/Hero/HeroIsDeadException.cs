namespace Classes.Exceptions.Game.Hero;

public class HeroIsDeadException : Exception
{
    public HeroIsDeadException() : base("Hero cannot perform this action because of unconsciousness.") { }
}
