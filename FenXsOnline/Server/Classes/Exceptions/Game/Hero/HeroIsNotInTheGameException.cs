namespace Classes.Exceptions.Game.Hero;

public class HeroIsNotInTheGameException : Exception
{
    public HeroIsNotInTheGameException() : base("Your any hero is not in the game.") { }
}
