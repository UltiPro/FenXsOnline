using AutoMapper;
using Classes.Enums.Game;
using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Item;
using Classes.Models.Game.Quest;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class QuestMenager : IQuestMenager
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly INpcMenager _npcMenager;
    private readonly IPromotionMenager _promotionMenager;
    private readonly IEquipmentMenager _equipmentMenager;

    public QuestMenager(DatabaseContext _context, IMapper _mapper, INpcMenager _npcMenager, IPromotionMenager _promotionMenager, IEquipmentMenager _equipmentMenager)
    {
        this._context = _context;
        this._mapper = _mapper;
        this._npcMenager = _npcMenager;
        this._promotionMenager = _promotionMenager;
        this._equipmentMenager = _equipmentMenager;
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

    public async Task<QuestCompletedResponse> TalkOrBring(string accountId, int questId)
    {
        var hero = await GetHero(accountId);

        var quest = await _context.Quests.FirstOrDefaultAsync(quest => quest.Id == questId);

        var heroQuest = await _context.HeroesQuests.FirstOrDefaultAsync(heroQuest => heroQuest.DBHero == hero && heroQuest.QuestId == questId);

        if (heroQuest is null) throw new HeroDidNotTakeThisQuestException();

        if (heroQuest.Done) throw new HeroHasDoneThisQuestException();

        var questStage = await _context.QuestStages.FirstOrDefaultAsync(questStage => questStage.QuestId == questId && questStage.Stage == heroQuest.Stage);

        if (questStage is null) throw new NotFoundException("Quest stage", $"{questId}, stage: {heroQuest.Stage}");

        if (questStage.NpcId is null) throw new NotFoundException("Npc quest stage", $"{questId}, stage: {heroQuest.Stage}");

        var npc = await _npcMenager.GetNpc(hero, (int)questStage.NpcId);

        if (questStage.ItemType != null && questStage.ItemId != null)
        {
            _equipmentMenager.FindItemForQuest(hero, new ItemProvider
            {
                ItemType = (ItemType)questStage.ItemType,
                ItemId = (int)questStage.ItemId
            });

            await _context.SaveChangesAsync();
        }

        if (await DoneStage(heroQuest, questStage))
        {
            var questRewards = await _context.QuestRewards.Where(questReward => questReward.QuestId == questId).ToListAsync();

            List<DBHeroEquipment> equipmentRewards = new List<DBHeroEquipment>();

            try
            {
                for (int i = 0; i < questRewards.Count; i++)
                {
                    for (int j = 0; j < questRewards[i].Quantity; j++)
                    {
                        equipmentRewards.Add(await _equipmentMenager.AddItem(hero, questRewards[i]));
                    }
                }
            }
            catch { }

            await _context.SaveChangesAsync();

            return new QuestCompletedResponse
            {
                PromotionResponse = await _promotionMenager.Promotion(hero, quest.Level, true),
                HeroEquipmentRewards = equipmentRewards
            };
        }

        return null;
    }

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

    private async Task<bool> DoneStage(DBHeroQuest heroQuest, DBQuestStage _questStage)
    {
        if (_context.QuestStages.Any(questStage =>
            questStage.QuestId == _questStage.QuestId && questStage.Stage == (_questStage.Stage + 1)))
            heroQuest.Stage += 1;
        else
            heroQuest.Done = true;

        await _context.SaveChangesAsync();

        return heroQuest.Done;
    }

    private async Task<DBHero> GetHero(string accountId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        return hero;
    }
}
