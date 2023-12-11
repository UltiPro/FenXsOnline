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
            Items = new List<ItemProvider>()
            {
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 4 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 5 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 6 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 7 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 8 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 9 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 10 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 11 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 12 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 13 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 14 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 15 },
                new ItemProvider() { ItemType = ItemType.Weapon, ItemId = 16 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 1 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 2 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 3 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 4 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 5 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 6 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 7 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 8 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 9 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 10 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 11 },
                new ItemProvider() { ItemType = ItemType.SecondaryWeapon, ItemId = 12 }
            }
        };
    }
}
