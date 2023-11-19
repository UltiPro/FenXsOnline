using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Item;

public class BaseItemWornable : BaseItem
{
    public int Level { get; set; } = 1;
    public int Weight { get; set; } = 1;
    public int Price { get; set; } = 1;
    public ICollection<DBHero>? Heroes { get; set; }
}
