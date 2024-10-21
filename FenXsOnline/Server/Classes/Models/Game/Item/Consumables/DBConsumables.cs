using Classes.Enums.Game;

namespace Classes.Models.Game.Item.Consumables;

public class DBConsumables : BaseItem
{
    public int Stamina { get; set; } = 0;
    public int Mana { get; set; } = 0;
    public int HealthPoints { get; set; } = 0;
    public int Gold { get; set; } = 0;
    public ItemType ItemType { get; set; } = ItemType.Consumables;
}
