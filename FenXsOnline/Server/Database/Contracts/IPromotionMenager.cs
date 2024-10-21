using Classes.Models.Game;

namespace Database.Contracts;

public interface IPromotionMenager
{
    Task<PromotionResponse> Promotion(int heroId, int level, bool quest);
}
