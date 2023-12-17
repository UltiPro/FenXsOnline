using Classes.Models.Game.Npc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBNpcConfiguration : IEntityTypeConfiguration<DBNpc>
{
    public void Configure(EntityTypeBuilder<DBNpc> builder)
    {
        builder.HasData(new DBNpc
        {
            Id = 1,
            MapId = 1,
            Name = "Adelaide",
            X = 36,
            Y = 49,
            SpriteURL = "adelide.gif",
            IsHealer = true,
            IsTrader = true,
            PricePercent = 0.75
        }, new DBNpc
        {
            Id = 2,
            MapId = 1,
            Name = "Eldrik",
            X = 19,
            Y = 39,
            SpriteURL = "eldrik.gif",
            IsTrader = true,
            PricePercent = 0.85
        }, new DBNpc
        {
            Id = 3,
            MapId = 1,
            Name = "Gustaf",
            X = 14,
            Y = 13,
            SpriteURL = "gustaf.gif",
            IsTrader = true,
            PricePercent = 0.80
        }, new DBNpc
        {
            Id = 4,
            MapId = 1,
            Name = "Franko",
            X = 56,
            Y = 36,
            SpriteURL = "franko.gif",
            IsTrader = true,
            PricePercent = 0.85
        });
    }
}
