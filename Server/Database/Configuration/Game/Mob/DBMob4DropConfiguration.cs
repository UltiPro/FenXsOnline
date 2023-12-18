using Classes.Enums.Game;
using Classes.Models.Game.Mob;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Mob;

public class DBMob4DropConfiguration : IEntityTypeConfiguration<DBMobDrop>
{
    public void Configure(EntityTypeBuilder<DBMobDrop> builder)
    {
        builder.HasData(new DBMobDrop
        {
            MobId = 4,
            ItemType = ItemType.Neutral,
            ItemId = 2,
        }, new DBMobDrop
        {
            MobId = 4,
            ItemType = ItemType.Neutral,
            ItemId = 3,
        }, new DBMobDrop
        {
            MobId = 4,
            ItemType = ItemType.Neutral,
            ItemId = 4,
        }, new DBMobDrop
        {
            MobId = 4,
            ItemType = ItemType.Consumables,
            ItemId = 11,
        });
    }
}
