using Classes.Enums.Game;
using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map.Instance.Npc;

public static class Map1Npc0
{
    public static MapNPC Get()
    {
        return new MapNPC
        {
            Id = 0,
            Name = "Adelide",
            X = 36,
            Y = 49,
            SpriteURL = "adelide.gif",
            IsHealer = true,
            IsTrader = true,
            PricePercent = 0.75,
            Items = new List<ItemProvider>()
            {
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 4 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 5 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 6 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 7 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 8 },
                new ItemProvider() { ItemType = ItemType.Consumables, ItemId = 9 }
            }
        };
    }
}
