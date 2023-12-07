namespace Classes.Exceptions.Game;

public class ItemRequiresAnotherProfessionException : Exception
{
    public ItemRequiresAnotherProfessionException(string professionName) : base($"Item requires {professionName} profession.") { }
}
