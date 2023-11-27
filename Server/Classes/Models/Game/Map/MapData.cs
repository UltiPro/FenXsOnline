namespace Classes.Models.Game.Map;

public class MapData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public bool IsPvP { get; set; }
    public bool[,] Fields { get; set; }
    public List<MapDoor>? Doors { get; set; } = null;
    //npcs
    //mobs
    //items
    //droped_items
}
