namespace Classes.Exceptions.Game;

public class TileIsOccupiedException : Exception
{
    public TileIsOccupiedException() : base("This tile is occupied.") { }
}
