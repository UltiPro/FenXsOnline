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
            Items = new List<ItemProvider>()
            {
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 4 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 5 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 6 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 7 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 8 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 9 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 10 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 11 },
                new ItemProvider() { ItemType = ItemType.Armor, ItemId = 12 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 4 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 5 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 6 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 7 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 8 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 9 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 10 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 11 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 12 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 13 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 14 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 15 },
                new ItemProvider() { ItemType = ItemType.Helmet, ItemId = 16 },
                new ItemProvider() { ItemType = ItemType.Boots, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Boots, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Boots, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Boots, ItemId = 4 },
                new ItemProvider() { ItemType = ItemType.Gloves, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Gloves, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Gloves, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Gloves, ItemId = 4 }
            }
        };
    }
}
