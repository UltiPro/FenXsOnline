using Classes.Enums.Game;
using Classes.Models.Game.Item.Gloves;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBGlovesConfiguration : IEntityTypeConfiguration<DBGloves>
{
    public void Configure(EntityTypeBuilder<DBGloves> builder)
    {
        builder.HasData(new DBGloves
        {
            Id = 1,
            Name = "Steel Bracelets",
            Weight = 4,
            Price = 5,
            SpriteURL = "glovesWarrior0.gif",
            Armor = 10,
            HealthPoints = 5,
            Profession = Profession.Warrior
        }, new DBGloves
        {
            Id = 2,
            Name = "Leather Gloves",
            Weight = 2,
            Price = 2,
            SpriteURL = "glovesHunter0.gif",
            Armor = 5,
            Agility = 5,
            HealthPoints = 5,
            Profession = Profession.Hunter
        }, new DBGloves
        {
            Id = 3,
            Name = "Black Gloves",
            Weight = 2,
            Price = 3,
            SpriteURL = "glovesMage0.gif",
            Armor = 2,
            MagicArmor = 8,
            HealthPoints = 5,
            Profession = Profession.Mage
        }, new DBGloves
        {
            Id = 4,
            Name = "Iron Paws",
            Weight = 4,
            Price = 5,
            SpriteURL = "glovesPaladin0.gif",
            Armor = 10,
            MagicArmor = 5,
            Agility = -2,
            Profession = Profession.Paladin
        });
    }
}
