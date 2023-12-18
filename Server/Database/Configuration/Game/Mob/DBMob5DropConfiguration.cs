using Classes.Enums.Game;
using Classes.Models.Game.Mob;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Mob;

public class DBMob5DropConfiguration : IEntityTypeConfiguration<DBMobDrop>
{
    public void Configure(EntityTypeBuilder<DBMobDrop> builder)
    {
        builder.HasData(new DBMobDrop
        {
            MobId = 5,
            ItemType = ItemType.Neutral,
            ItemId = 14,
        }, new DBMobDrop
        {
            MobId = 5,
            ItemType = ItemType.Neutral,
            ItemId = 7,
        }, new DBMobDrop
        {
            MobId = 5,
            ItemType = ItemType.Neutral,
            ItemId = 9,
        }, new DBMobDrop
        {
            MobId = 5,
            ItemType = ItemType.Consumables,
            ItemId = 3,
        });
    }
}
