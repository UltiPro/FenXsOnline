namespace Classes.Models.Game.Map;

public class MapDoor : MapPosition
{
    public int ToMapId { get; set; }
    public int ToX { get; set; }
    public int ToY { get; set; }
}
