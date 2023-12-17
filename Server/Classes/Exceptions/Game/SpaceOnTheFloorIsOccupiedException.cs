namespace Classes.Exceptions.Game;

public class SpaceOnTheFloorIsOccupiedException : Exception
{
    public SpaceOnTheFloorIsOccupiedException() : base("This space on the floor is occupied.") { }
}
