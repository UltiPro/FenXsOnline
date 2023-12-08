using Classes.Enums.Game;

namespace Classes.Models.Game.Item;

public class BaseItemWornableProfession : BaseItemWornable
{
    public Profession Profession { get; set; }
}
