namespace Classes.Exceptions.Game.Item;

public class ItemRequiresAnotherProfessionException : Exception
{
    public ItemRequiresAnotherProfessionException(string professionName) : base($"Item requires {professionName} profession.") { }
}
