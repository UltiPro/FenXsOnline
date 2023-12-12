using Classes.Enums.Game;
using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map.Instance.Npc;

public static class Map1Npc3
{
    public static MapNPC Get()
    {
        return new MapNPC
        {
            Id = 3,
            Name = "Franko",
            X = 56,
            Y = 36,
            SpriteURL = "franko.gif",
            IsTrader = true,
            PricePercent = 0.85,
            Items = new List<ItemProviderSlot>()
            {
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 1, Id = 19 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 2, Id = 20 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 3, Id = 21 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 4, Id = 22 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 5, Id = 25 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 6, Id = 26 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 7, Id = 27 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 8, Id = 28 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 9, Id = 31 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 10, Id = 32 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 11, Id = 33 },
                new ItemProviderSlot() { ItemType = ItemType.Armor, ItemId = 12, Id = 34 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 1, Id = 1 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 2, Id = 2 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 3, Id = 3 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 4, Id = 4 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 5, Id = 7 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 6, Id = 8 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 7, Id = 9 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 8, Id = 10 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 9, Id = 13 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 10, Id = 14 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 11, Id = 15 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 12, Id = 16 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 13, Id = 5 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 14, Id = 6 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 15, Id = 11 },
                new ItemProviderSlot() { ItemType = ItemType.Helmet, ItemId = 16, Id = 12 },
                new ItemProviderSlot() { ItemType = ItemType.Boots, ItemId = 1, Id = 43 },
                new ItemProviderSlot() { ItemType = ItemType.Boots, ItemId = 2, Id = 44 },
                new ItemProviderSlot() { ItemType = ItemType.Boots, ItemId = 3, Id = 45 },
                new ItemProviderSlot() { ItemType = ItemType.Boots, ItemId = 4, Id = 46 },
                new ItemProviderSlot() { ItemType = ItemType.Gloves, ItemId = 1, Id = 37 },
                new ItemProviderSlot() { ItemType = ItemType.Gloves, ItemId = 2, Id = 38 },
                new ItemProviderSlot() { ItemType = ItemType.Gloves, ItemId = 3, Id = 39 },
                new ItemProviderSlot() { ItemType = ItemType.Gloves, ItemId = 4, Id = 40 }
            }
        };
    }
}
