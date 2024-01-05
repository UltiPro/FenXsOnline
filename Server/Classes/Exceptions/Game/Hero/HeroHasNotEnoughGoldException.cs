namespace Classes.Exceptions.Game.Hero;

public class HeroHasNotEnoughGoldException : Exception
{
    public HeroHasNotEnoughGoldException() : base("Hero has not enough gold.") { }
}
