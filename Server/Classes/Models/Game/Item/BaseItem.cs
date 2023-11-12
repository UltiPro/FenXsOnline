namespace Classes.Models.Game.Item;

public class BaseItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public int HealthPoints { get; set; }
    public int Stamina { get; set; }
    public int Mana { get; set; }
    public int Weight { get; set; }
    public int Price { get; set; }
    public bool AvailableInFight { get; set; }
}
