using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Fight;

public class FightResponse
{
    public int HelathPoints { get; set; }
    public PromotionResponse? PromotionResponse { get; set; }
    public DBHeroEquipment? Drop { get; set; }
    public DeadResponse? DeadResponse { get; set; }
    public List<string> Logs { get; set; }
}
