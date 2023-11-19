using Classes.Enums.Game;
using Classes.Models.Game.Item.Boots;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBBootsConfiguration : IEntityTypeConfiguration<DBBoots>
{
    public void Configure(EntityTypeBuilder<DBBoots> builder)
    {
        builder.HasData(new DBBoots
        {
            Id = 1,
            Name = "Chainmail Boots",
            Weight = 2,
            Price = 5,
            SpriteURL = "bootsWarrior0.gif",
            Armor = 5,
            Agility = 5,
            Profession = Profession.Warrior
        }, new DBBoots
        {
            Id = 2,
            Name = "Sheepskin Boots",
            Weight = 1,
            Price = 1,
            SpriteURL = "bootsHunter0.gif",
            Armor = 1,
            Agility = 5,
            HealthPoints = 5,
            Profession = Profession.Hunter
        }, new DBBoots
        {
            Id = 3,
            Name = "Leather Slippers",
            Weight = 1,
            Price = 2,
            SpriteURL = "bootsMage0.gif",
            MagicArmor = 5,
            Agility = 2,
            HealthPoints = 3,
            Profession = Profession.Mage
        }, new DBBoots
        {
            Id = 4,
            Name = "Steel Boots",
            Weight = 3,
            Price = 10,
            SpriteURL = "bootsPaladin0.gif",
            Armor = 15,
            MagicArmor = 5,
            Profession = Profession.Paladin
        });
    }
}
