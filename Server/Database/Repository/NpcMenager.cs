using Classes.Enums.Game;
using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Item;
using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Consumables;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Neutral;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;
using Classes.Models.Game.Npc;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class NpcMenager : INpcMenager
{
    private readonly DatabaseContext _context;
    private readonly IEquipmentMenager _equipmentMenager;
    private readonly IItemMenager _itemMenager;
    private readonly World _world;

    public NpcMenager(DatabaseContext _context, IEquipmentMenager _equipmentMenager, IItemMenager _itemMenager)
    {
        this._context = _context;
        this._equipmentMenager = _equipmentMenager;
        this._itemMenager = _itemMenager;
        _world = World.GetInstance();
    }

    public async Task Heal(string accountId, int npcId)
    {
        var hero = await GetHero(accountId);

        var npc = await GetNpc(hero, npcId);

        if (npc.IsHealer)
        {
            hero.HealthPoints = hero.MaxHealthPoints;

            await _context.SaveChangesAsync();

            return;
        }

        throw new BadRequestException("This NPC is not a healer.");
    }

    public async Task<int> Sell(string accountId, int npcId, int itemId)
    {
        var hero = await GetHero(accountId);

        var npc = await GetNpc(hero, npcId);

        if (npc.IsTrader)
        {
            var slot = await _context.HeroesEquipments.FirstOrDefaultAsync(slot => slot.DBHero == hero && slot.Id == itemId);

            if (slot is null || slot.ItemType is null || slot.ItemId is null) throw new HeroEquipmentSlotIsEmptyException();

            var item = await GetBaseItem((ItemType)slot.ItemType, (int)slot.ItemId);

            var coins = (int)(item.Price * npc.PricePercent);

            hero.Gold += coins;

            slot.ItemType = null;
            slot.ItemId = null;

            await _context.SaveChangesAsync();

            return coins;
        }

        throw new BadRequestException("This NPC is not a trader.");
    }

    public async Task<DBHeroEquipment> Buy(string accountId, int npcId, int itemId)
    {
        var hero = await GetHero(accountId);

        var npc = await GetNpc(hero, npcId);

        if (npc.IsTrader)
        {
            var itemNpc = _context.NpcsItem.FirstOrDefault(npcItem => npcItem.DBNpc == npc && npcItem.Id == itemId);

            if (itemNpc is null) throw new BadRequestException("This npc do not sell item in provided slot.");

            var item = await GetBaseItem(itemNpc.ItemType, itemNpc.ItemId);

            if (hero.Gold < item.Price) throw new HeroHasNotEnoughGoldException();

            var itemEq = await _equipmentMenager.AddItem(hero, itemNpc);

            hero.Gold -= item.Price;

            await _context.SaveChangesAsync();

            return itemEq;
        }

        throw new BadRequestException("This NPC is not a trader.");
    }

    private async Task<DBHero> GetHero(string accountId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        return hero;
    }

    public async Task<DBNpc> GetNpc(DBHero hero, int npcId)
    {
        var npc = await _context.Npcs.FirstOrDefaultAsync(npc => npc.Id == npcId);

        if (npc is null) throw new NotFoundException("NPC", npcId);

        if (npc.MapId != hero.MapId || Math.Sqrt(Math.Pow(npc.X - hero.X, 2) + Math.Pow(npc.Y - hero.Y, 2)) > 2)
            throw new HeroIsTooFarAwayException();

        return npc;
    }

    private async Task<BaseItem> GetBaseItem(ItemType itemType, int itemId)
    {
        BaseItem item;

        switch (itemType)
        {
            case ItemType.Armor:
                item = await _itemMenager.GetBaseItem<DBArmor>(itemId);
                break;
            case ItemType.Boots:
                item = await _itemMenager.GetBaseItem<DBBoots>(itemId);
                break;
            case ItemType.Gloves:
                item = await _itemMenager.GetBaseItem<DBGloves>(itemId);
                break;
            case ItemType.Helmet:
                item = await _itemMenager.GetBaseItem<DBHelmet>(itemId);
                break;
            case ItemType.Necklace:
                item = await _itemMenager.GetBaseItem<DBNecklace>(itemId);
                break;
            case ItemType.Ring:
                item = await _itemMenager.GetBaseItem<DBRing>(itemId);
                break;
            case ItemType.SecondaryWeapon:
                item = await _itemMenager.GetBaseItem<DBSecondaryWeapon>(itemId);
                break;
            case ItemType.Weapon:
                item = await _itemMenager.GetBaseItem<DBWeapon>(itemId);
                break;
            case ItemType.Consumables:
                item = await _itemMenager.GetBaseItem<DBConsumables>(itemId);
                break;
            case ItemType.Neutral:
                item = await _itemMenager.GetBaseItem<DBNeutral>(itemId);
                break;
            default:
                throw new ItemIsNotSellableException();
        }

        return item;
    }
}
