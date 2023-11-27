using Classes.Enums.Game;
using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class EquipmentMenager : IEquipmentMenager
{
    private readonly DatabaseContext _context;

    public EquipmentMenager(DatabaseContext _context)
    {
        this._context = _context;
    }

    public async Task Create(int heroId)
    {
        for (int i = 1; i < 31; i++)
        {
            await _context.HeroesEquipments.AddAsync(new DBHeroEquipment
            {
                HeroId = heroId,
                Id = i
            });
        }

        await _context.SaveChangesAsync();
    }

    public async Task Delete(int heroId)
    {
        _context.HeroesEquipments.RemoveRange(await _context.HeroesEquipments.Where(heroEquipment => heroEquipment.HeroId == heroId).ToListAsync());
    }

    public async Task AddItem(string accountId, ItemType itemType, int itemId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        var freeSlot = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment =>
            heroEquipment.DBHero == hero &&
            heroEquipment.ItemType == null &&
            heroEquipment.ItemId == null);

        if (freeSlot is null) throw new HeroEquipmentIsFullException();

        freeSlot.ItemType = itemType;
        freeSlot.ItemId = itemId;

        await _context.SaveChangesAsync();
    }

    public async Task MoveItem(string accountId, int fromSlotId, int toSlotId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        var slot_1 = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == fromSlotId);
        var slot_2 = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == toSlotId);

        if (slot_1 is null || slot_2 is null || (slot_1.ItemType is null && slot_2.ItemType is null))
            throw new BadRequestException("Invalid equipment IDs.");

        ItemType? copyType = slot_1.ItemType;
        int? copyId = slot_1.ItemId;

        slot_1.ItemType = slot_2.ItemType;
        slot_1.ItemId = slot_2.ItemId;

        slot_2.ItemType = copyType;
        slot_2.ItemId = copyId;

        await _context.SaveChangesAsync();
    }

    public async Task RemoveItem(string accountId, int slotId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        var slot = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == slotId);

        if (slot is null || slot.ItemType is null) throw new BadRequestException("There is no item in this slot.");

        slot.ItemType = null;
        slot.ItemId = null;

        await _context.SaveChangesAsync();
    }

    public async Task<bool> HasItem(int heroId, ItemType itemType, int itemId)
    {
        return await _context.HeroesEquipments.AnyAsync(heroEquipment =>
            heroEquipment.HeroId == heroId &&
            heroEquipment.ItemType == itemType &&
            heroEquipment.ItemId == itemId);
    }

    public Task<bool> UseItem(string accountId, int slotId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UnuseItem(string accountId, ItemType itemType, int slotId)
    {
        throw new NotImplementedException();
    }
}
