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
            Items = new List<ItemProviderSlot>()
            {
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 1, Id = 1 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 2, Id = 7 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 3, Id = 13 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 4, Id = 2 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 5, Id = 8 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 6, Id = 14 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 7, Id = 3 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 8, Id = 9 },
                new ItemProviderSlot() { ItemType = ItemType.Consumables, ItemId = 9, Id = 15 }
            }
        };
    }
}
