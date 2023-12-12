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
            Items = new List<ItemProviderSlot>()
            {
                new ItemProviderSlot() { ItemType = ItemType.Ring, ItemId = 1, Id = 1 },
                new ItemProviderSlot() { ItemType = ItemType.Ring, ItemId = 2, Id = 2 },
                new ItemProviderSlot() { ItemType = ItemType.Ring, ItemId = 3, Id = 3 },
                new ItemProviderSlot() { ItemType = ItemType.Necklace, ItemId = 1, Id = 7 },
                new ItemProviderSlot() { ItemType = ItemType.Necklace, ItemId = 2, Id = 8 },
                new ItemProviderSlot() { ItemType = ItemType.Necklace, ItemId = 3, Id = 9 }
            }
        };
    }
}
