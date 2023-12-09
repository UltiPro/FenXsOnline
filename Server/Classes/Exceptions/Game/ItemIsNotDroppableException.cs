namespace Classes.Exceptions.Game;

public class ItemIsNotDroppableException : Exception
{
    public ItemIsNotDroppableException() : base("This item cannot be dropped.") { }
}
