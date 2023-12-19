using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Fight;

public class FightMobResponse
{
    public bool PlayerWin { get; set; }
    public int HelathPoints { get; set; }
    public DBHeroEquipment? Drop { get; set; }
    public int MapId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public DateTime? Dead { get; set; }
    public List<string> Logs { get; set; }
}
