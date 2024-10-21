using Classes.Models.Game.Hero;

namespace Database.Contracts;

public interface IHeroMenager : IGenericRepository<DBHero>
{
    Task<bool> IsAvailableNickname(string nickname);
    Task<bool> IsHeroLimitReached(string accountId);
    Task<HeroBasicInfo> CreateHero(HeroCreateBackend heroCreateBackend);
    Task<bool> IsHeroThisUser(string accountId, int heroId);
    Task DeleteHero(int id);
    Task<List<HeroBasicInfo>> GetHeroes(string accountId);
    Task ChangeSprite(int heroId, int spriteLevel);
    Task Play(string accountId, int heroId);
    Task Leave(string accountId);
    Task<DBHero> GetInGameHero(string accountId);
}
