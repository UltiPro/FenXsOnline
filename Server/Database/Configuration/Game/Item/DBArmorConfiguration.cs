using Classes.Enums.Game;
using Classes.Models.Game.Item.Armor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Item;

public class DBArmorConfiguration : IEntityTypeConfiguration<DBArmor>
{
    public void Configure(EntityTypeBuilder<DBArmor> builder)
    {
        builder.HasData(new DBArmor
        {
            Id = 1,
            Name = "Red Caftan",
            Weight = 5,
            Price = 20,
            SpriteURL = "armorWarrior0.gif",
            Armor = 30,
            Agility = 5,
            HealthPoints = 5,
            Profession = Profession.Warrior
        }, new DBArmor
        {
            Id = 2,
            Name = "Leather Armor",
            Weight = 3,
            Price = 20,
            SpriteURL = "armorHunter0.gif",
            Armor = 20,
            Agility = 10,
            Profession = Profession.Hunter
        }, new DBArmor
        {
            Id = 3,
            Name = "Wanderer's Coat",
            Weight = 3,
            Price = 20,
            SpriteURL = "armorMage0.gif",
            Armor = 5,
            MagicArmor = 15,
            Agility = 5,
            HealthPoints = 20,
            Profession = Profession.Mage
        }, new DBArmor
        {
            Id = 4,
            Name = "Incomplete Armor",
            Weight = 7,
            Price = 20,
            SpriteURL = "armorPaladin0.gif",
            Armor = 10,
            MagicArmor = 10,
            HealthPoints = 10,
            Profession = Profession.Paladin
        }, new DBArmor
        {
            Id = 5,
            Name = "Wanderer's Chainmail",
            Level = 10,
            Weight = 10,
            Price = 50,
            SpriteURL = "armorWarrior10.gif",
            Armor = 55,
            HealthPoints = 15,
            Profession = Profession.Warrior
        }, new DBArmor
        {
            Id = 6,
            Name = "Tunic Of Agility",
            Level = 10,
            Weight = 5,
            Price = 35,
            SpriteURL = "armorHunter10.gif",
            Armor = 25,
            Agility = 25,
            HealthPoints = 5,
            Profession = Profession.Hunter
        }, new DBArmor
        {
            Id = 7,
            Name = "Novice's Coat",
            Level = 10,
            Weight = 5,
            Price = 30,
            SpriteURL = "armorMage10.gif",
            Armor = 15,
            MagicArmor = 35,
            Agility = 5,
            HealthPoints = 20,
            Profession = Profession.Mage
        }, new DBArmor
        {
            Id = 8,
            Name = "Steel Breastplate",
            Level = 10,
            Weight = 15,
            Price = 55,
            SpriteURL = "armorPaladin10.gif",
            Armor = 25,
            MagicArmor = 25,
            HealthPoints = 10,
            Profession = Profession.Paladin
        }, new DBArmor
        {
            Id = 9,
            Name = "Reinforced Wanderer's Chainmail",
            Level = 20,
            Weight = 15,
            Price = 250,
            SpriteURL = "armorWarrior20.gif",
            Armor = 100,
            Agility = 5,
            HealthPoints = 30,
            Profession = Profession.Warrior
        }, new DBArmor
        {
            Id = 10,
            Name = "Hunter's Tunic",
            Level = 20,
            Weight = 10,
            Price = 150,
            SpriteURL = "armorHunter20.gif",
            Armor = 65,
            Agility = 15,
            HealthPoints = 35,
            Profession = Profession.Hunter
        }, new DBArmor
        {
            Id = 11,
            Name = "Thinker's Coat",
            Level = 20,
            Weight = 8,
            Price = 200,
            SpriteURL = "armorMage20.gif",
            Armor = 30,
            MagicArmor = 95,
            Agility = 5,
            HealthPoints = 50,
            Profession = Profession.Mage
        }, new DBArmor
        {
            Id = 12,
            Name = "Guardian Armor",
            Level = 20,
            Weight = 20,
            Price = 350,
            SpriteURL = "armorPaladin20.gif",
            Armor = 75,
            MagicArmor = 75,
            HealthPoints = 50,
            Profession = Profession.Paladin
        });
    }
}
