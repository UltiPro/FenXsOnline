namespace Classes.Exceptions.Game;

public class HeroHasNotRequiredItemsException : Exception
{
    public HeroHasNotRequiredItemsException() : base("Hero has not the required items.") { }
}
