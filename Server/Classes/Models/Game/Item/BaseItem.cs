using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Item;

public class BaseItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; } = 1;
    public int Weight { get; set; } = 1;
    public int Price { get; set; } = 1;
    public string SpriteURL { get; set; }
    public bool QuestItem { get; set; } = false;
    public ICollection<DBHero>? Heroes { get; set; }
}
