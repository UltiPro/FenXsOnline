using Classes.Enums.Game;

namespace Classes.Models.Game.Hero;

public class HeroBasicInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; } = 1;
    public Profession Profession { get; set; }
    public Sex Sex { get; set; }
    public int HealthPoints { get; set; } = 100;
    public int MaxHealthPoints { get; set; } = 100;
    public int Mana { get; set; } = 0;
    public int MaxMana { get; set; } = 0;
    public int Stamina { get; set; } = 0;
    public int MaxStamina { get; set; } = 0;
    public string SpriteURL { get; set; }
}
