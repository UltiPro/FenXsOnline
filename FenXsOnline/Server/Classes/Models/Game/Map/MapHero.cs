using Classes.Enums.Game;

namespace Classes.Models.Game.Map;

public class MapHero : MapPosition
{
    public string Name { get; set; }
    public int Level { get; set; }
    public Profession Profession { get; set; }
    public Sex Sex { get; set; }
    public string SpriteURL { get; set; }
}
