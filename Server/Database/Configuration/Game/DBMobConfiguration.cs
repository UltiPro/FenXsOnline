using Classes.Models.Game.Mob;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBMobConfiguration : IEntityTypeConfiguration<DBMob>
{
    public void Configure(EntityTypeBuilder<DBMob> builder)
    {
        builder.HasData(new DBMob
        {
            Id = 1,
            Name = "Rabbit",
            SpriteUrl = "rabbit.gif",
            Level = 1,
            HealthPoints = 100,
            Atack = 5,
            Agility = 15
        }, new DBMob
        {
            Id = 2,
            Name = "Spider",
            SpriteUrl = "spider.gif",
            Level = 5,
            HealthPoints = 100,
            Atack = 10,
            CriticalChance = 5,
            Agility = 5,
            DropChance = 25
        }, new DBMob
        {
            Id = 3,
            Name = "Wolf",
            SpriteUrl = "wolf.gif",
            Level = 10,
            HealthPoints = 150,
            Atack = 15,
            CriticalChance = 20,
            Agility = 10,
            Weight = 10,
            DropChance = 25
        }, new DBMob
        {
            Id = 4,
            Name = "Boar",
            SpriteUrl = "boar.gif",
            Level = 15,
            HealthPoints = 200,
            Atack = 25,
            CriticalChance = 20,
            Armor = 10,
            Agility = 10,
            Weight = 20,
            DropChance = 25
        }, new DBMob
        {
            Id = 5,
            Name = "Apparition",
            SpriteUrl = "apparition.gif",
            Level = 20,
            HealthPoints = 350,
            Atack = 25,
            MagicAtack = 25,
            CriticalChance = 15,
            Armor = 50,
            MagicArmor = 100,
            Agility = 10,
            Weight = 35,
            DropChance = 15
        });
    }
}
