using Classes.Models.Game.Hero;

namespace Database.Contracts;

public interface IHeroMenager : IGenericRepository<DBHero>
{
    Task<bool> IsAvailableNickname(string nickname);
    Task<bool> IsHeroLimitReached(string accountId);
    Task<bool> IsHeroThisUser(string accountId, int heroId);
    Task<List<HeroBasicInfo>> GetHeroes(string accountId);
    Task ChangeSprite(int heroId, int spriteLevel);
    Task Play(string accountId, int heroId);
    Task<DBHero> GetInGameHero(string accountId);
}
