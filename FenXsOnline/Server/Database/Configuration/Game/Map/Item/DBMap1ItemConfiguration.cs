using Classes.Enums.Game;
using Classes.Models.Game.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Map.Item;

public class DBMap1ItemConfiguration : IEntityTypeConfiguration<DBMapItem>
{
    public void Configure(EntityTypeBuilder<DBMapItem> builder)
    {
        builder.HasData(new DBMapItem
        {
            MapId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 10,
            X = 16,
            Y = 94,
            Available = DateTime.Now
        }, new DBMapItem
        {
            MapId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 10,
            X = 15,
            Y = 69,
            Available = DateTime.Now
        }, new DBMapItem
        {
            MapId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 10,
            X = 3,
            Y = 49,
            Available = DateTime.Now
        }, new DBMapItem
        {
            MapId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 10,
            X = 55,
            Y = 43,
            Available = DateTime.Now
        }, new DBMapItem
        {
            MapId = 1,
            ItemType = ItemType.ToQuest,
            ItemId = 5,
            X = 56,
            Y = 71,
            Available = DateTime.Now
        });
    }
}
