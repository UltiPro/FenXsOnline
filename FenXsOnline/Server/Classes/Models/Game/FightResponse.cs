using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Fight;

public class FightResponse
{
    public int HealthPoints { get; set; }
    public PromotionResponse? Promotion { get; set; }
    public DBHeroEquipment? Drop { get; set; }
    public DeadResponse? Dead { get; set; }
    public List<string> Logs { get; set; }
}
