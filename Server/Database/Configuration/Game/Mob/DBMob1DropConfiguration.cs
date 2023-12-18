using Classes.Enums.Game;
using Classes.Models.Game.Mob;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Mob;

public class DBMob1DropConfiguration : IEntityTypeConfiguration<DBMobDrop>
{
    public void Configure(EntityTypeBuilder<DBMobDrop> builder)
    {
        builder.HasData(new DBMobDrop
        {
            MobId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 11,
        });
    }
}
