namespace Classes.Models.Game.Item;

public class BaseItemJewelry : BaseItem
{
    public int HealthPoints { get; set; } = 0;
    public int Stamina { get; set; } = 0;
    public int Mana { get; set; } = 0;
    public int CriticalChance { get; set; } = 0;
}
