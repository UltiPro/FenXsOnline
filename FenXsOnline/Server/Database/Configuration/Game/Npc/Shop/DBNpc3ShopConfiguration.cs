using Classes.Enums.Game;
using Classes.Models.Game.Npc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Npc.Shop;

public class DBNpc3ShopConfiguration : IEntityTypeConfiguration<DBNpcShopItem>
{
    public void Configure(EntityTypeBuilder<DBNpcShopItem> builder)
    {
        builder.HasData(
            new DBNpcShopItem() { NpcId = 3, Id = 1, ItemType = ItemType.Ring, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 3, Id = 2, ItemType = ItemType.Ring, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 3, Id = 3, ItemType = ItemType.Ring, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 3, Id = 7, ItemType = ItemType.Necklace, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 3, Id = 8, ItemType = ItemType.Necklace, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 3, Id = 9, ItemType = ItemType.Necklace, ItemId = 3 }
            );
    }
}
