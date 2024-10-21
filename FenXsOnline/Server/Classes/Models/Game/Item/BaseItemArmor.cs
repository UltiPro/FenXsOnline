namespace Classes.Models.Game.Item;

public class BaseItemArmor : BaseItemWornableProfession
{
    public int Armor { get; set; } = 1;
    public int MagicArmor { get; set; } = 0;
    public int Agility { get; set; } = 0;
    public int HealthPoints { get; set; } = 0;
}
