using Classes.Enums.Game;

namespace Classes.Models.Game.Map;

public class MapHero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; } = 1;
    public Profession Profession { get; set; }
    public Sex Sex { get; set; }
    public string SpriteURL { get; set; }
}
