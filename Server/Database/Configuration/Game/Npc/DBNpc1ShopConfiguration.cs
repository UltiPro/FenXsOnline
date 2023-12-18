using Classes.Enums.Game;
using Classes.Models.Game.Npc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Npc;

public class DBNpc1ShopConfiguration : IEntityTypeConfiguration<DBNpcShopItem>
{
    public void Configure(EntityTypeBuilder<DBNpcShopItem> builder)
    {
        builder.HasData(
            new DBNpcShopItem() { NpcId = 1, Id = 1, ItemType = ItemType.Consumables, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 1, Id = 7, ItemType = ItemType.Consumables, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 1, Id = 13, ItemType = ItemType.Consumables, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 1, Id = 2, ItemType = ItemType.Consumables, ItemId = 4 },
            new DBNpcShopItem() { NpcId = 1, Id = 8, ItemType = ItemType.Consumables, ItemId = 5 },
            new DBNpcShopItem() { NpcId = 1, Id = 14, ItemType = ItemType.Consumables, ItemId = 6 },
            new DBNpcShopItem() { NpcId = 1, Id = 3, ItemType = ItemType.Consumables, ItemId = 7 },
            new DBNpcShopItem() { NpcId = 1, Id = 9, ItemType = ItemType.Consumables, ItemId = 8 },
            new DBNpcShopItem() { NpcId = 1, Id = 15, ItemType = ItemType.Consumables, ItemId = 9 }
            );
    }
}
