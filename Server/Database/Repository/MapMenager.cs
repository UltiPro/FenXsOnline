using AutoMapper;
using Classes.Exceptions.Game;
using Classes.Models.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Map;
using Classes.Enums.Game;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;
using Classes.Models.Game.Npc;
using Classes.Models.Game.Quest;
using Classes.Exceptions.Game.Hero;
using Classes.Exceptions.Game.Item;

namespace Database.Repository;

public class MapMenager : IMapMenager
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly IEquipmentMenager _equipmentMenager;
    private readonly World _world;

    public MapMenager(DatabaseContext _context, IMapper _mapper, IEquipmentMenager _equipmentMenager)
    {
        this._context = _context;
        this._mapper = _mapper;
        this._equipmentMenager = _equipmentMenager;
        _world = World.GetInstance();
    }

    public async Task<MapDataResponse> Get(string accountId)
    {
        var hero = await GetHero(accountId);

        var mapDataResponse = _mapper.Map<MapDataResponse>(_world.Maps[hero.MapId]);

        var npcs = _mapper.Map<List<NpcQuestResponse>>(await _context.Npcs.Include(npc => npc.ShopItems).Where(npc => npc.MapId == hero.MapId).ToListAsync());

        var heroQuests = _context.HeroesQuests.Where(heroQuest => heroQuest.DBHero == hero);

        npcs.ForEach(npc =>
        {
            npc.Quests = _mapper.Map<List<QuestResponse>>(
                _context.Quests.Where(
                    quest => quest.NpcId == npc.Id && quest.Level <= hero.Level && !heroQuests.Select(heroQuest => heroQuest.QuestId).Contains(quest.Id))
                .ToList());
        });

        heroQuests = heroQuests.Where(heroQuest => !heroQuest.Done);

        heroQuests.ToList().ForEach(heroQuest =>
        {
            var questStage = _context.QuestStages.FirstOrDefault(questStage => questStage.QuestId == heroQuest.QuestId && questStage.Stage == heroQuest.Stage && questStage.Talk);

            if (questStage != null)
            {
                var npc = npcs.Find(npc => npc.Id == questStage.NpcId);

                if (npc != null) npc.QuestsStage.Add(_mapper.Map<QuestNpcMessage>(questStage));
            }
        });

        mapDataResponse.NPCs = npcs;
        mapDataResponse.Mobs = await _context.MapMobs.Where(mapMob => mapMob.MapId == hero.MapId && mapMob.Available < DateTime.Now).ToListAsync();
        mapDataResponse.Items = await _context.MapItems.Where(mapItem => mapItem.MapId == hero.MapId && (mapItem.Available < DateTime.Now || mapItem.Available == null)).ToListAsync();
        mapDataResponse.Heroes = _mapper.Map<List<MapHero>>(await _context.Heroes.Where(h => h.InGame && h.MapId == hero.MapId && h != hero).ToListAsync());

        return mapDataResponse;
    }

    public async Task<MapDataRefresh> GetRefresh(string accountId)
    {
        var hero = await GetHero(accountId);

        return new MapDataRefresh
        {
            Mobs = await _context.MapMobs.Where(mapMob => mapMob.MapId == hero.MapId && mapMob.Available < DateTime.Now).ToListAsync(),
            Items = await _context.MapItems.Where(mapItem => mapItem.MapId == hero.MapId && (mapItem.Available < DateTime.Now || mapItem.Available == null)).ToListAsync(),
            Heroes = _mapper.Map<List<MapHero>>(await _context.Heroes.Where(h => h.InGame && h.MapId == hero.MapId && h != hero).ToListAsync())
        };
    }

    public async Task<DBMapItem> DropItem(string accountId, int itemId)
    {
        var hero = await GetHero(accountId);

        var slot = hero.HeroEquipment.FirstOrDefault(slot => slot.Id == itemId);

        if (slot is null || slot.ItemType is null || slot.ItemId is null) throw new HeroEquipmentSlotIsEmptyException();

        if (slot.ItemType is ItemType.ToQuest) throw new ItemIsNotDroppableException();

        if (await _context.MapItems.AnyAsync(mapItem => mapItem.MapId == hero.MapId
            && mapItem.X == hero.X && mapItem.Y == hero.Y)) throw new TileIsOccupiedException();

        var itemOnGround = new DBMapItem
        {
            ItemType = (ItemType)slot.ItemType,
            ItemId = (int)slot.ItemId,
            MapId = hero.MapId,
            X = hero.X,
            Y = hero.Y
        };

        await _context.MapItems.AddAsync(itemOnGround);

        slot.ItemType = null;
        slot.ItemId = null;

        await _context.SaveChangesAsync();

        return itemOnGround;
    }

    public async Task<DBHeroEquipment> GrabItem(string accountId)
    {
        var hero = await GetHero(accountId);

        var item = await _context.MapItems.FirstOrDefaultAsync(item =>
            item.MapId == hero.MapId && item.X == hero.X && item.Y == hero.Y);

        if (item is null || item.Available > DateTime.Now) return null;

        var itemEq = await _equipmentMenager.AddItem(hero, item);

        if (item.Available != null) item.Available = DateTime.Now.AddMinutes(10);
        else _context.MapItems.Remove(item);

        await _context.SaveChangesAsync();

        return itemEq;
    }

    private async Task<DBHero> GetHero(string accountId)
    {
        var hero = await _context.Heroes
            .Include(hero => hero.HeroEquipment)
            .FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        return hero;
    }
}
