using Classes.Enums.Game;
using Classes.Models.Game.Item;

namespace Classes.Models.Game.Map.Instance.Npc;

public static class Map1Npc2
{
    public static MapNPC Get()
    {
        return new MapNPC
        {
            Id = 2,
            Name = "Gustaf",
            X = 14,
            Y = 13,
            SpriteURL = "gustaf.gif",
            IsTrader = true,
            PricePercent = 0.80,
            Items = new List<ItemProvider>()
            {
                new ItemProvider() { ItemType = ItemType.Ring, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Ring, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Ring, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Necklace, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Necklace, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Necklace, ItemId = 3 }
            }
        };
    }
}
