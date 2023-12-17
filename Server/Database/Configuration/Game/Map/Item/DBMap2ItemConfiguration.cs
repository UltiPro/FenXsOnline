using Classes.Enums.Game;
using Classes.Models.Game.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Map.Item;

public class DBMap2ItemConfiguration : IEntityTypeConfiguration<DBMapItem>
{
    public void Configure(EntityTypeBuilder<DBMapItem> builder)
    {
        builder.HasData(new DBMapItem
        {
            MapId = 2,
            X = 20,
            Y = 12,
            ItemType = ItemType.Consumables,
            ItemId = 12,
            Available = DateTime.Now
        }, new DBMapItem
        {
            MapId = 2,
            X = 1,
            Y = 2,
            ItemType = ItemType.Consumables,
            ItemId = 12,
            Available = DateTime.Now
        });
    }
}
