namespace Classes.Models.Game.Item;

public class BaseItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SpriteURL { get; set; }
    public int Price { get; set; } = 1;
}
