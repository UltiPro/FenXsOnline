namespace Classes.Exceptions;

public class BannedException : Exception
{
    public BannedException() : base("Your account has been banned.") { }
}
