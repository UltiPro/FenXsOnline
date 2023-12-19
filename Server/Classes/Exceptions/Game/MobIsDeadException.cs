namespace Classes.Exceptions.Game;

public class MobIsDeadException : Exception
{
    public MobIsDeadException() : base("This enemy is already dead.") { }
}
