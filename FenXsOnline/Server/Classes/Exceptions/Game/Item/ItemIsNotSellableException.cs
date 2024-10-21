namespace Classes.Exceptions.Game.Item;

public class ItemIsNotSellableException : Exception
{
    public ItemIsNotSellableException() : base("This item is not sellable.") { }
}
