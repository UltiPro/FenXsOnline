namespace Classes.Exceptions.Game;

public class ItemIsNotSellableException : Exception
{
    public ItemIsNotSellableException() : base("This item is not sellable.") { }
}
