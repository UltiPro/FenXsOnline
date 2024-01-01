using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Quest;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class QuestMenager : IQuestMenager
{
    private readonly DatabaseContext _context;
    private readonly INpcMenager _npcMenager;

    public QuestMenager(DatabaseContext _context, INpcMenager _npcMenager)
    {
        this._context = _context;
        this._npcMenager = _npcMenager;
    }

    public async Task TakeQuest(string accountId, int questId)
    {
        var hero = await GetHero(accountId);

        var quest = await _context.Quests.FirstOrDefaultAsync(quest => quest.Id == questId);

        if (quest is null) throw new NotFoundException("Quest", questId);

        if (quest.Level > hero.Level) throw new HeroLevelTooLowException(quest.Level);

        if (await _context.HeroesQuests.AnyAsync(heroQuest => heroQuest.DBHero == hero && heroQuest.DBQuest == quest))
            throw new HeroHasThisQuestException();

        await _npcMenager.GetNpc(hero, quest.NpcId);

        _context.HeroesQuests.Add(new DBHeroQuest
        {
            DBHero = hero,
            DBQuest = quest
        });

        await _context.SaveChangesAsync();
    }

    private async Task<DBHero> GetHero(string accountId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        return hero;
    }
}
