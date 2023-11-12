namespace Classes.Models.Game.Item;

public class BaseItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public int HealthPoints { get; set; } = 0;
    public int Agility { get; set; } = 0;
    public int Stamina { get; set; } = 0;
    public int Mana { get; set; } = 0;
    public int Weight { get; set; } = 1;
    public int Price { get; set; } = 1;
    public bool AvailableInFight { get; set; } = false;
}
