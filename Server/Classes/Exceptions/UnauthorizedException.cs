namespace Classes.Exceptions;

public class UnauthorizedException : Exception
{
    UnauthorizedException() : base("You are not permitted to do this action.") { }
}
