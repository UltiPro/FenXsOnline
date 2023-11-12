namespace Classes.Models.Game.Item;

public class BaseItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; } = 1;
    public int Weight { get; set; } = 1;
    public int Price { get; set; } = 1;
    public bool QuestItem { get; set; } = false;
}
