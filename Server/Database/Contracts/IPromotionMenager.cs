using Classes.Models.Game;
using Classes.Models.Game.Hero;

namespace Database.Contracts;

public interface IPromotionMenager
{
    PromotionResponse Promotion(DBHero hero, int level, bool quest);
}
