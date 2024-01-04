using AutoMapper;
using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Quest;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Database.Repository;

public class QuestMenager : IQuestMenager
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly INpcMenager _npcMenager;

    public QuestMenager(DatabaseContext _context, IMapper _mapper, INpcMenager _npcMenager)
    {
        this._context = _context;
        this._mapper = _mapper;
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

    public async Task<List<QuestStageResponse>> GetQuestsInfo(string accountId)
    {
        var hero = await GetHero(accountId);

        var questsIDs = _context.HeroesQuests.Where(heroQuest => heroQuest.DBHero == hero && !heroQuest.Done).Select(heroQuest => heroQuest.QuestId);

        var quests = _mapper.Map<List<QuestStageResponse>>(_context.Quests.Where(quest => questsIDs.Contains(quest.Id)));

        DBHeroQuest? heroQuest;
        DBQuestStage? questStage;

        quests.ForEach(quest =>
        {
            heroQuest = _context.HeroesQuests.FirstOrDefault(heroQuest => heroQuest.DBHero == hero && heroQuest.QuestId == quest.Id);
            questStage = _context.QuestStages.FirstOrDefault(questStage => questStage.QuestId == quest.Id && questStage.Stage == heroQuest.Stage);
            if (questStage != null)
                quest.Description = questStage.Description;
            if (questStage.Kill)
                quest.Description += $" (Killed: {heroQuest.Quantity}/{questStage.Quantity})";
        });

        return quests;
    }

    public async Task DoQuest(string accountId, int questId)
    {
        var hero = await GetHero(accountId);

        var heroQuest = await _context.HeroesQuests.FirstOrDefaultAsync(heroQuest => heroQuest.DBHero == hero && heroQuest.QuestId == questId);

        if (heroQuest is null) throw new HeroDidNotTakeThisQuestException();

        if(heroQuest.Done) throw new HeroHasDoneThisQuestException();

        var questStage = await _context.QuestStages.FirstOrDefaultAsync(questStage => questStage.QuestId == questId && questStage.Stage == heroQuest.Stage);

        if (questStage is null) throw new NotFoundException("Quest stage", $"{questId}, stage: {heroQuest.Stage}");

        if (questStage.Talk)
            throw new NotImplementedException();
        else if(questStage.Bring)
            throw new NotImplementedException();
        else if(questStage.Kill)
            throw new NotImplementedException();
    }

    private async Task Talk(DBHero hero, int questId)
    {
        
    }

    /*public Task Bring(DBHero hero)
    {
        throw new NotImplementedException();
    }*/

    public async Task Kill(DBHero hero, int mobId)
    {
        var heroQuests = await _context.HeroesQuests.Where(heroQuest => heroQuest.DBHero == hero && !heroQuest.Done).ToListAsync();

        heroQuests.ForEach(heroQuest =>
        {
            var questStage = _context.QuestStages.FirstOrDefault(questStage => 
                questStage.QuestId == heroQuest.QuestId && questStage.Stage == heroQuest.Stage);
            if (questStage.Kill && questStage.MobId == mobId)
            {
                heroQuest.Quantity += 1;
                if (heroQuest.Quantity >= questStage.Quantity) DoneStage(heroQuest, questStage);
            }
        });
    }

    private bool DoneStage(DBHeroQuest heroQuest, DBQuestStage _questStage) /* to */
    {
        if (_context.QuestStages.Any(questStage => 
            questStage.QuestId == _questStage.QuestId && questStage.Stage == (_questStage.Stage + 1))) 
                heroQuest.Stage += 1;
        else
            heroQuest.Done = true;

        _context.SaveChanges();

        if (heroQuest.Done) return true;
        else return false;
    }

    /*private async Task GetReward()
    {

    }*/

    private async Task<DBHero> GetHero(string accountId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        return hero;
    }
}
