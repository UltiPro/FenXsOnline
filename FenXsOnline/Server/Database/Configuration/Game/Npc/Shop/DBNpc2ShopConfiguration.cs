using Classes.Enums.Game;
using Classes.Models.Game.Npc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Npc.Shop;

public class DBNpc2ShopConfiguration : IEntityTypeConfiguration<DBNpcShopItem>
{
    public void Configure(EntityTypeBuilder<DBNpcShopItem> builder)
    {
        builder.HasData(
            new DBNpcShopItem() { NpcId = 2, Id = 1, ItemType = ItemType.Weapon, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 2, Id = 7, ItemType = ItemType.Weapon, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 2, Id = 13, ItemType = ItemType.Weapon, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 2, Id = 19, ItemType = ItemType.Weapon, ItemId = 4 },
            new DBNpcShopItem() { NpcId = 2, Id = 2, ItemType = ItemType.Weapon, ItemId = 5 },
            new DBNpcShopItem() { NpcId = 2, Id = 8, ItemType = ItemType.Weapon, ItemId = 6 },
            new DBNpcShopItem() { NpcId = 2, Id = 14, ItemType = ItemType.Weapon, ItemId = 7 },
            new DBNpcShopItem() { NpcId = 2, Id = 20, ItemType = ItemType.Weapon, ItemId = 8 },
            new DBNpcShopItem() { NpcId = 2, Id = 3, ItemType = ItemType.Weapon, ItemId = 9 },
            new DBNpcShopItem() { NpcId = 2, Id = 9, ItemType = ItemType.Weapon, ItemId = 10 },
            new DBNpcShopItem() { NpcId = 2, Id = 15, ItemType = ItemType.Weapon, ItemId = 11 },
            new DBNpcShopItem() { NpcId = 2, Id = 21, ItemType = ItemType.Weapon, ItemId = 12 },
            new DBNpcShopItem() { NpcId = 2, Id = 4, ItemType = ItemType.Weapon, ItemId = 13 },
            new DBNpcShopItem() { NpcId = 2, Id = 10, ItemType = ItemType.Weapon, ItemId = 14 },
            new DBNpcShopItem() { NpcId = 2, Id = 16, ItemType = ItemType.Weapon, ItemId = 15 },
            new DBNpcShopItem() { NpcId = 2, Id = 22, ItemType = ItemType.Weapon, ItemId = 16 },
            new DBNpcShopItem() { NpcId = 2, Id = 25, ItemType = ItemType.SecondaryWeapon, ItemId = 1 },
            new DBNpcShopItem() { NpcId = 2, Id = 31, ItemType = ItemType.SecondaryWeapon, ItemId = 2 },
            new DBNpcShopItem() { NpcId = 2, Id = 37, ItemType = ItemType.SecondaryWeapon, ItemId = 3 },
            new DBNpcShopItem() { NpcId = 2, Id = 43, ItemType = ItemType.SecondaryWeapon, ItemId = 4 },
            new DBNpcShopItem() { NpcId = 2, Id = 26, ItemType = ItemType.SecondaryWeapon, ItemId = 5 },
            new DBNpcShopItem() { NpcId = 2, Id = 32, ItemType = ItemType.SecondaryWeapon, ItemId = 6 },
            new DBNpcShopItem() { NpcId = 2, Id = 38, ItemType = ItemType.SecondaryWeapon, ItemId = 7 },
            new DBNpcShopItem() { NpcId = 2, Id = 44, ItemType = ItemType.SecondaryWeapon, ItemId = 8 },
            new DBNpcShopItem() { NpcId = 2, Id = 27, ItemType = ItemType.SecondaryWeapon, ItemId = 9 },
            new DBNpcShopItem() { NpcId = 2, Id = 33, ItemType = ItemType.SecondaryWeapon, ItemId = 10 },
            new DBNpcShopItem() { NpcId = 2, Id = 39, ItemType = ItemType.SecondaryWeapon, ItemId = 11 },
            new DBNpcShopItem() { NpcId = 2, Id = 45, ItemType = ItemType.SecondaryWeapon, ItemId = 12 }
            );
    }
}
