namespace Classes.Exceptions;

public class UnauthorizedException : Exception
{
    public UnauthorizedException() : base("You are not permitted to do this action.") { }
}
