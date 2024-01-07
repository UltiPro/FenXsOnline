namespace Classes.Exceptions.Game.Item;

public class ItemIsNotDroppableException : Exception
{
    public ItemIsNotDroppableException() : base("This item cannot be dropped.") { }
}
