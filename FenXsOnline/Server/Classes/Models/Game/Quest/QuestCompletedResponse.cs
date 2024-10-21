using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Quest;

public class QuestCompletedResponse
{
    public PromotionResponse PromotionResponse { get; set; }
    public List<DBHeroEquipment> HeroEquipmentRewards { get; set; }
}
