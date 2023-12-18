using Classes.Enums.Game;
using Classes.Models.Game.Npc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Npc;

public class DBNpc4ShopConfiguration : IEntityTypeConfiguration<DBNpcShopItem>
{
    public void Configure(EntityTypeBuilder<DBNpcShopItem> builder)
    {
        builder.HasData(
            new DBNpcShopItem() { NpcId = 4, Id = 19, ItemType = ItemType.Armor, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 4, Id = 20, ItemType = ItemType.Armor, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 4, Id = 21, ItemType = ItemType.Armor, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 4, Id = 22, ItemType = ItemType.Armor, ItemId = 4 },
            new DBNpcShopItem() { NpcId = 4, Id = 25, ItemType = ItemType.Armor, ItemId = 5 },
            new DBNpcShopItem() { NpcId = 4, Id = 26, ItemType = ItemType.Armor, ItemId = 6 },
            new DBNpcShopItem() { NpcId = 4, Id = 27, ItemType = ItemType.Armor, ItemId = 7 },
            new DBNpcShopItem() { NpcId = 4, Id = 28, ItemType = ItemType.Armor, ItemId = 8 },
            new DBNpcShopItem() { NpcId = 4, Id = 31, ItemType = ItemType.Armor, ItemId = 9 },
            new DBNpcShopItem() { NpcId = 4, Id = 32, ItemType = ItemType.Armor, ItemId = 10 },
            new DBNpcShopItem() { NpcId = 4, Id = 33, ItemType = ItemType.Armor, ItemId = 11 },
            new DBNpcShopItem() { NpcId = 4, Id = 34, ItemType = ItemType.Armor, ItemId = 12 },
            new DBNpcShopItem() { NpcId = 4, Id = 1, ItemType = ItemType.Helmet, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 4, Id = 2, ItemType = ItemType.Helmet, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 4, Id = 3, ItemType = ItemType.Helmet, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 4, Id = 4, ItemType = ItemType.Helmet, ItemId = 4 },
            new DBNpcShopItem() { NpcId = 4, Id = 7, ItemType = ItemType.Helmet, ItemId = 5 },
            new DBNpcShopItem() { NpcId = 4, Id = 8, ItemType = ItemType.Helmet, ItemId = 6 },
            new DBNpcShopItem() { NpcId = 4, Id = 9, ItemType = ItemType.Helmet, ItemId = 7 },
            new DBNpcShopItem() { NpcId = 4, Id = 10, ItemType = ItemType.Helmet, ItemId = 8 },
            new DBNpcShopItem() { NpcId = 4, Id = 13, ItemType = ItemType.Helmet, ItemId = 9 },
            new DBNpcShopItem() { NpcId = 4, Id = 14, ItemType = ItemType.Helmet, ItemId = 10 },
            new DBNpcShopItem() { NpcId = 4, Id = 15, ItemType = ItemType.Helmet, ItemId = 11 },
            new DBNpcShopItem() { NpcId = 4, Id = 16, ItemType = ItemType.Helmet, ItemId = 12 },
            new DBNpcShopItem() { NpcId = 4, Id = 5, ItemType = ItemType.Helmet, ItemId = 13 },
            new DBNpcShopItem() { NpcId = 4, Id = 6, ItemType = ItemType.Helmet, ItemId = 14 },
            new DBNpcShopItem() { NpcId = 4, Id = 11, ItemType = ItemType.Helmet, ItemId = 15 },
            new DBNpcShopItem() { NpcId = 4, Id = 12, ItemType = ItemType.Helmet, ItemId = 16 },
            new DBNpcShopItem() { NpcId = 4, Id = 43, ItemType = ItemType.Boots, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 4, Id = 44, ItemType = ItemType.Boots, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 4, Id = 45, ItemType = ItemType.Boots, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 4, Id = 46, ItemType = ItemType.Boots, ItemId = 4 },
            new DBNpcShopItem() { NpcId = 4, Id = 37, ItemType = ItemType.Gloves, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 4, Id = 38, ItemType = ItemType.Gloves, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 4, Id = 39, ItemType = ItemType.Gloves, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 4, Id = 40, ItemType = ItemType.Gloves, ItemId = 4 }
            );
    }
}
