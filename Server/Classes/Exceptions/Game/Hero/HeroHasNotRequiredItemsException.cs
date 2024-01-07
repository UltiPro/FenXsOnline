namespace Classes.Exceptions.Game.Hero;

public class HeroHasNotRequiredItemsException : Exception
{
    public HeroHasNotRequiredItemsException() : base("Hero has not the required items.") { }
}
