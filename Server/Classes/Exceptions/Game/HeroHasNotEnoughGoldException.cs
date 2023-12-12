namespace Classes.Exceptions.Game;

public class HeroHasNotEnoughGoldException : Exception
{
    public HeroHasNotEnoughGoldException() : base("Hero has not enough gold to buy this item.") { }
}
