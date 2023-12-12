using Classes.Enums.Game;
using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map.Instance.Npc;

public static class Map1Npc1
{
    public static MapNPC Get()
    {
        return new MapNPC
        {
            Id = 1,
            Name = "Eldrik",
            X = 19,
            Y = 39,
            SpriteURL = "eldrik.gif",
            IsTrader = true,
            PricePercent = 0.85,
            Items = new List<ItemProviderSlot>()
            {
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 1, Id = 1 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 2, Id = 7 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 3, Id = 13 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 4, Id = 19 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 5, Id = 2 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 6, Id = 8 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 7, Id = 14 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 8, Id = 20 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 9, Id = 3 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 10, Id = 9 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 11, Id = 15 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 12, Id = 21 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 13, Id = 4 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 14, Id = 10 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 15, Id = 16 },
                new ItemProviderSlot() { ItemType = ItemType.Weapon, ItemId = 16, Id = 22 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 1, Id = 25 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 2, Id = 31 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 3, Id = 37 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 4, Id = 43 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 5, Id = 26 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 6, Id = 32 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 7, Id = 38 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 8, Id = 44 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 9, Id = 27 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 10, Id = 33 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 11, Id = 39 },
                new ItemProviderSlot() { ItemType = ItemType.SecondaryWeapon, ItemId = 12, Id = 45 }
            }
        };
    }
}
