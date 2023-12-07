namespace Classes.Exceptions.Game;

public class ItemIsNotWornableException : Exception
{
    public ItemIsNotWornableException() : base("This item is not for use.") { }
}
