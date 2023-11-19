using Classes.Models.Game.Item.Ring;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBRingConfiguration : IEntityTypeConfiguration<DBRing>
{
    public void Configure(EntityTypeBuilder<DBRing> builder)
    {
        builder.HasData(new DBRing
        {
            Id = 1,
            Name = "Father's Ring",
            Price = 5,
            SpriteURL = "ring0.gif",
            Stamina = 5,
            Mana = 10,
            HealthPoints = 100
        }, new DBRing
        {
            Id = 2,
            Name = "Health Ring",
            Level = 10,
            Weight = 2,
            Price = 15,
            SpriteURL = "ring10.gif",
            Stamina = 10,
            HealthPoints = 200
        }, new DBRing
        {
            Id = 3,
            Name = "Critical Ring",
            Level = 20,
            Weight = 2,
            Price = 40,
            SpriteURL = "ring20.gif",
            HealthPoints = 50,
            CriticalChance = 10
        }
        );
    }
}
