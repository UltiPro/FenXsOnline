namespace Classes.Exceptions;

public class UnauthorizedException : Exception
{
    public UnauthorizedException(string? message) : base(message ?? "You are not permitted to do this action.") { }
}
