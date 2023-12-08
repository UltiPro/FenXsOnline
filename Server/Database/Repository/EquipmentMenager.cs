using Classes.Enums.Game;
using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Item;
using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Consumables;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class EquipmentMenager : IEquipmentMenager
{
    private readonly DatabaseContext _context;
    private readonly IHeroMenager _heroMenager;

    public EquipmentMenager(DatabaseContext _context, IHeroMenager _heroMenager)
    {
        this._context = _context;
        this._heroMenager = _heroMenager;
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
        var hero = await _heroMenager.GetInGameHeroBackend(accountId);

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
        var hero = await _heroMenager.GetInGameHeroBackend(accountId);

        var slot_1 = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == fromSlotId);
        var slot_2 = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == toSlotId);

        if (slot_1 is null || slot_2 is null || (slot_1.ItemType is null && slot_2.ItemType is null))
            throw new HeroEquipmentSlotIsEmptyException();

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
        var hero = await _heroMenager.GetInGameHeroBackend(accountId);

        var slot = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == slotId);

        if (slot is null || slot.ItemType is null) throw new HeroEquipmentSlotIsEmptyException();

        slot.ItemType = null;
        slot.ItemId = null;

        await _context.SaveChangesAsync();
    }

    public async Task<DBHero> UseItem(string accountId, int slotId)
    {
        if (slotId < 1) throw new BadRequestException("Slot id needs to be larger than 0.");

        var hero = await _heroMenager.GetInGameHeroBackend(accountId);

        var slot = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == slotId);

        if (slot is null || slot.ItemType is null) throw new HeroEquipmentSlotIsEmptyException();

        switch (slot.ItemType)
        {
            case ItemType.Armor:
                var armor = await CheckItem<DBArmor>(hero, slot);
                if (hero.DBArmor != null)
                {
                    slot.ItemType = hero.DBArmor.ItemType;
                    slot.ItemId = hero.DBArmor.Id;
                }
                else ClearSlot(slot);
                hero.DBArmor = armor;
                UpdateArmor(hero, armor, 1);
                break;
            case ItemType.Boots:
                var boots = await CheckItem<DBBoots>(hero, slot);
                if (hero.DBBoots != null)
                {
                    slot.ItemType = hero.DBBoots.ItemType;
                    slot.ItemId = hero.DBBoots.Id;
                }
                else ClearSlot(slot);
                hero.DBBoots = boots;
                UpdateArmor(hero, boots, 1);
                break;
            case ItemType.Gloves:
                var gloves = await CheckItem<DBGloves>(hero, slot);
                if (hero.DBGloves != null)
                {
                    slot.ItemType = hero.DBGloves.ItemType;
                    slot.ItemId = hero.DBGloves.Id;
                }
                else ClearSlot(slot);
                hero.DBGloves = gloves;
                UpdateArmor(hero, gloves, 1);
                break;
            case ItemType.Helmet:
                var helmet = await CheckItem<DBHelmet>(hero, slot);
                if (hero.DBHelmet != null)
                {
                    slot.ItemType = hero.DBHelmet.ItemType;
                    slot.ItemId = hero.DBHelmet.Id;
                }
                else ClearSlot(slot);
                hero.DBHelmet = helmet;
                UpdateArmor(hero, helmet, 1);
                break;
            case ItemType.Necklace:
                var necklace = await CheckItem<DBNecklace>(hero, slot);
                if (hero.DBNecklace != null)
                {
                    slot.ItemType = hero.DBNecklace.ItemType;
                    slot.ItemId = hero.DBNecklace.Id;
                }
                else ClearSlot(slot);
                hero.DBNecklace = necklace;
                UpdateJewelry(hero, necklace, 1);
                break;
            case ItemType.Ring:
                var ring = await CheckItem<DBRing>(hero, slot);
                if (hero.DBRing != null)
                {
                    slot.ItemType = hero.DBRing.ItemType;
                    slot.ItemId = hero.DBRing.Id;
                }
                else ClearSlot(slot);
                hero.DBRing = ring;
                UpdateJewelry(hero, ring, 1);
                break;
            case ItemType.SecondaryWeapon:
                var secondaryWeapon = await CheckItem<DBSecondaryWeapon>(hero, slot);
                if (hero.DBSecondaryWeapon != null)
                {
                    slot.ItemType = hero.DBSecondaryWeapon.ItemType;
                    slot.ItemId = hero.DBSecondaryWeapon.Id;
                }
                else ClearSlot(slot);
                hero.DBSecondaryWeapon = secondaryWeapon;
                UpdateSecondaryWeapon(hero, secondaryWeapon, 1);
                break;
            case ItemType.Weapon:
                var weapon = await CheckItem<DBWeapon>(hero, slot);
                if (hero.DBWeapon != null)
                {
                    slot.ItemType = hero.DBWeapon.ItemType;
                    slot.ItemId = hero.DBWeapon.Id;
                }
                else ClearSlot(slot);
                hero.DBWeapon = weapon;
                UpdateWeapon(hero, weapon, 1);
                break;
            case ItemType.Consumables:
                var consumable = await _context.Consumables.FirstOrDefaultAsync(item => item.Id == slot.ItemId);
                if (consumable is null) throw new NotFoundException("Consumable", slot.ItemId);
                UseConsumable(hero, consumable);
                ClearSlot(slot);
                break;
            default:
                throw new ItemIsNotWornableException();
        }

        await _context.SaveChangesAsync();

        return hero;
    }

    private async Task<T> CheckItem<T>(DBHero hero, DBHeroEquipment slot) where T : BaseItemWornable
    {
        T? item = await _context.Set<T>().FirstOrDefaultAsync(item => item.Id == slot.ItemId);

        if (item is null) throw new NotFoundException(nameof(T), slot.ItemId);

        if (typeof(T).IsSubclassOf(typeof(BaseItemWornable)))
        {
            if (item.Level > hero.Level) throw new HeroLevelTooLowException(item.Level);
        }

        if (typeof(T).IsSubclassOf(typeof(BaseItemWornableProfession)))
        {
            if ((item as BaseItemWornableProfession).Profession != hero.Profession) throw new ItemRequiresAnotherProfessionException((item as BaseItemWornableProfession).Profession.ToString());
        }

        return item;
    }

    public async Task<DBHero> UnuseItem(string accountId, ItemType itemType, int slotId)
    {
        if (slotId < 1) throw new BadRequestException("Slot id needs to be larger than 0.");

        var hero = await _heroMenager.GetInGameHeroBackend(accountId);

        var slot = await _context.HeroesEquipments.FirstOrDefaultAsync(heroEquipment => heroEquipment.DBHero == hero && heroEquipment.Id == slotId);

        if (slot is null) throw new BadRequestException("Incorrect slot id provided.");

        if (slot.ItemId != null) throw new HeroEquipmentSlotIsOccupiedException();

        switch (slot.ItemType)
        {
            case ItemType.Armor:
                SetSlot(slot, hero.DBArmor.ItemType, hero.DBArmor.Id);
                UpdateArmor(hero, hero.DBArmor, -1);
                hero.DBArmor = null;
                break;
            case ItemType.Boots:
                SetSlot(slot, hero.DBBoots.ItemType, hero.DBBoots.Id);
                UpdateArmor(hero, hero.DBBoots, -1);
                hero.DBBoots = null;
                break;
            case ItemType.Gloves:
                SetSlot(slot, hero.DBGloves.ItemType, hero.DBGloves.Id);
                UpdateArmor(hero, hero.DBGloves, -1);
                hero.DBGloves = null;
                break;
            case ItemType.Helmet:
                SetSlot(slot, hero.DBHelmet.ItemType, hero.DBHelmet.Id);
                UpdateArmor(hero, hero.DBHelmet, -1);
                hero.DBHelmet = null;
                break;
            case ItemType.Necklace:
                SetSlot(slot, hero.DBNecklace.ItemType, hero.DBNecklace.Id);
                UpdateJewelry(hero, hero.DBNecklace, -1);
                hero.DBNecklace = null;
                break;
            case ItemType.Ring:
                SetSlot(slot, hero.DBRing.ItemType, hero.DBRing.Id);
                UpdateJewelry(hero, hero.DBRing, -1);
                hero.DBRing = null;
                break;
            case ItemType.SecondaryWeapon:
                SetSlot(slot, hero.DBSecondaryWeapon.ItemType, hero.DBSecondaryWeapon.Id);
                UpdateSecondaryWeapon(hero, hero.DBSecondaryWeapon, -1);
                hero.DBSecondaryWeapon = null;
                break;
            case ItemType.Weapon:
                SetSlot(slot, hero.DBWeapon.ItemType, hero.DBWeapon.Id);
                UpdateWeapon(hero, hero.DBWeapon, -1);
                hero.DBWeapon = null;
                break;
            default:
                throw new ItemIsNotWornableException();
        }

        await _context.SaveChangesAsync();

        return hero;
    }

    private void ClearSlot(DBHeroEquipment slot)
    {
        slot.ItemType = null;
        slot.ItemId = null;
    }

    private void SetSlot(DBHeroEquipment slot, ItemType itemType, int itemId)
    {
        slot.ItemType = itemType;
        slot.ItemId = itemId;
    }

    private void UpdateArmor(DBHero hero, BaseItemArmor item, int plus)
    {
        hero.Weight += plus * item.Weight;
        hero.Armor += plus * item.Armor;
        hero.MagicArmor += plus * item.MagicArmor;
        hero.Agility += plus * item.Agility;
        hero.MaxHealthPoints += plus * item.HealthPoints;
    }

    private void UpdateJewelry(DBHero hero, BaseItemJewelry item, int plus)
    {
        hero.Weight += plus * item.Weight;
        hero.MaxStamina += plus * item.Stamina;
        hero.MaxMana += plus * item.Mana;
        hero.MaxHealthPoints += plus * item.HealthPoints;
        hero.CriticalChance += plus * item.CriticalChance;
    }

    private void UpdateWeapon(DBHero hero, DBWeapon item, int plus)
    {
        hero.Weight += plus * item.Weight;
        hero.Atack += plus * item.Atack;
        hero.MagicAtack += plus * item.MagicAtack;
        hero.CriticalChance += plus * item.CriticalChance;
    }

    private void UpdateSecondaryWeapon(DBHero hero, DBSecondaryWeapon item, int plus)
    {
        hero.Weight += plus * item.Weight;
        hero.Atack += plus * item.Atack;
        hero.MagicAtack += plus * item.MagicAtack;
        hero.CriticalChance += plus * item.CriticalChance;
        hero.Armor += plus * item.Armor;
        hero.MagicArmor += plus * item.MagicArmor;
    }

    private void UseConsumable(DBHero hero, DBConsumables consumable)
    {
        hero.Stamina += consumable.Stamina;
        if (hero.Stamina > hero.MaxStamina) hero.Stamina = hero.MaxStamina;
        hero.Mana += consumable.Mana;
        if (hero.Mana > hero.MaxMana) hero.Mana = hero.MaxMana;
        hero.HealthPoints += consumable.HealthPoints;
        if (hero.HealthPoints > hero.MaxHealthPoints) hero.HealthPoints = hero.MaxHealthPoints;
        hero.Gold += consumable.Gold;
    }
}
