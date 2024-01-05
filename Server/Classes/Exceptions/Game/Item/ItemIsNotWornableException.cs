namespace Classes.Exceptions.Game.Item;

public class ItemIsNotWornableException : Exception
{
    public ItemIsNotWornableException() : base("This item is not for use.") { }
}
