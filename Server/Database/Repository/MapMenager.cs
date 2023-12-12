using AutoMapper;
using Classes.Exceptions.Game;
using Classes.Models.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Item;
using Classes.Models.Game.Map;
using Classes.Enums.Game;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

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

        mapDataResponse.Heroes = _mapper.Map<List<MapHero>>(await _context.Heroes.Where(h => h.InGame == true && h.MapId == hero.MapId && h != hero).ToListAsync());

        return mapDataResponse;
    }

    public async Task<MapDataRefresh> GetRefresh(string accountId)
    {
        var hero = await GetHero(accountId);

        var mapDataRefresh = _mapper.Map<MapDataRefresh>(_world.Maps[hero.MapId]);

        mapDataRefresh.Heroes = _mapper.Map<List<MapHero>>(await _context.Heroes.Where(h => h.InGame == true && h.MapId == hero.MapId && h != hero).ToListAsync());

        return mapDataRefresh;
    }

    public async Task<ItemProviderGround> DropItem(string accountId, int itemId)
    {
        var hero = await GetHero(accountId);

        var slot = hero.HeroEquipment.FirstOrDefault(slot => slot.Id == itemId);

        if (slot is null || slot.ItemType is null || slot.ItemId is null) throw new HeroEquipmentSlotIsEmptyException();

        if (slot.ItemType is ItemType.ToQuest) throw new ItemIsNotDroppableException();

        var itemOnGround = new ItemProviderGround
        {
            ItemType = (ItemType)slot.ItemType,
            ItemId = (int)slot.ItemId,
            X = hero.X,
            Y = hero.Y
        };

        _world.Maps[hero.MapId].Items.Add(itemOnGround);

        slot.ItemType = null;
        slot.ItemId = null;

        await _context.SaveChangesAsync();

        return itemOnGround;
    }

    public async Task<DBHeroEquipment> GrabItem(string accountId)
    {
        var hero = await GetHero(accountId);

        var item = _world.Maps[hero.MapId].Items.FirstOrDefault(item => item.X == hero.X && item.Y == hero.Y);

        if (item is null) return null;

        var itemEq = await _equipmentMenager.AddItem(accountId, item);

        _world.Maps[hero.MapId].Items.Remove(item);

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
