namespace Classes.Exceptions.Game;

public class HeroIsDeadException : Exception
{
    public HeroIsDeadException() : base("Hero cannot perform this action because of unconscious.") { }
}
