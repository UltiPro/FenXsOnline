using Classes.Enums.Game;

namespace Classes.Models.Game.Item;

public class BaseItemArmor : BaseItemWornable
{
    public int Armor { get; set; } = 1;
    public int MagicArmor { get; set; } = 0;
    public int Agility { get; set; } = 0;
    public int HealthPoints { get; set; } = 0;
    public Profession Profession { get; set; }
}
