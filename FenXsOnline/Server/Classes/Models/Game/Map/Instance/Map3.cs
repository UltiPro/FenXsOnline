namespace Classes.Models.Game.Map.Instance;

public class Map3 : MapFieldsHelper
{
    public static MapData Get()
    {
        return new MapData
        {
            Name = "Ruins",
            SpriteURL = "ruins.png",
            IsPvP = false
        };
    }
}
