using Classes.Models.Game.Hero;

namespace Database.Contracts;

public interface IHeroMenager : IGenericRepository<DBHero>
{
    public Task<bool> IsAvailableNickname(string nickname);
    public Task<bool> IsHeroLimitReached(string accountId);
    public Task<bool> IsHeroThisUser(string accountId, int heroId);
    public Task<List<HeroBasicInfo>> GetHeroes(string accountId);
    public Task ChangeSprite(int heroId, int spriteLevel);
    public Task Play(string accountId, int heroId);
    public Task<DBHero> GetInGameHero(string accountId);
}
