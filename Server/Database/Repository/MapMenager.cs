using AutoMapper;
using Classes.Exceptions.Game;
using Classes.Models.Game;
using Classes.Models.Game.Hero;
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

        var itemEq = await _equipmentMenager.AddItem(accountId, item);

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
