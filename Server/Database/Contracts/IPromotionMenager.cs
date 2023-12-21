using Classes.Models.Game;

namespace Database.Contracts;

public interface IPromotionMenager
{
    Task<PromotionResponse> Promotion(string accountId, int level, bool quest);
}
