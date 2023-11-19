using Classes.Models.Game.Item.Necklace;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBNecklaceConfiguration : IEntityTypeConfiguration<DBNecklace>
{
    public void Configure(EntityTypeBuilder<DBNecklace> builder)
    {
        builder.HasData(new DBNecklace
        {
            Id = 1,
            Name = "Father's Necklace",
            Price = 10,
            SpriteURL = "necklace0.gif",
            Stamina = 20,
            CriticalChance = 5
        }, new DBNecklace
        {
            Id = 2,
            Name = "Necklace of Magic",
            Level = 10,
            Weight = 3,
            Price = 20,
            SpriteURL = "necklace10.gif",
            Mana = 40
        }, new DBNecklace
        {
            Id = 3,
            Name = "Necklace of Fortune",
            Level = 20,
            Weight = 2,
            Price = 200,
            SpriteURL = "necklace20.gif",
            Stamina = 10,
            Mana = 10,
            CriticalChance = 5,
        });
    }
}
