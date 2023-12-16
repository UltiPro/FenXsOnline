using Classes.Enums.Game;
using Classes.Models.Game.Mob;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBMobDropConfiguration : IEntityTypeConfiguration<DBMobDrop>
{
    public void Configure(EntityTypeBuilder<DBMobDrop> builder)
    {
        builder.HasData(new DBMobDrop
        {
            MobId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 11,
        }, new DBMobDrop
        {
            MobId = 2,
            ItemType = ItemType.Neutral,
            ItemId = 6,
        }, new DBMobDrop
        {
            MobId = 3,
            ItemType = ItemType.Neutral,
            ItemId = 5,
        }, new DBMobDrop
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
        }, new DBMobDrop
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
