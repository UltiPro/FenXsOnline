using Classes.Models.Game;
using Classes.Models.Game.Hero;
using Database.Contracts;

namespace Database.Repository;

public class PromotionMenager : IPromotionMenager
{
    private readonly DatabaseContext _context;

    private readonly double x = 1.5;

    public PromotionMenager(DatabaseContext _context)
    {
        this._context = _context;
    }

    public async Task<PromotionResponse> Promotion(DBHero hero, int level, bool quest)
    {
        int experience;

        try
        {
            if (quest) experience = (int)Math.Ceiling((LevelExperience(level) / 2 / (x + Convert.ToDouble(level) / 10)) * (1 + Convert.ToDouble(level) / 20));
            else experience = (int)Math.Floor((LevelExperience(level) / 100 * (x / level)) + level + 1);
        }
        catch { experience = 0; }

        hero.Experience += experience;

        int nextLeveLExperience = LevelExperience(hero.Level);

        while (hero.Experience > nextLeveLExperience)
        {
            hero.Experience -= nextLeveLExperience;
            hero.Level += 1;
            nextLeveLExperience = LevelExperience(hero.Level);
        }

        await _context.SaveChangesAsync();

        return new PromotionResponse
        {
            Level = hero.Level,
            Experience = hero.Experience,
            GainedExperience = experience
        };
    }

    private int LevelExperience(int level) => (int)Math.Floor(10 * Math.Pow(x, level));
}
