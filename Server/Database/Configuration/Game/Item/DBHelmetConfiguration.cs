using Classes.Enums.Game;
using Classes.Models.Game.Item.Helmet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Item;

public class DBHelmetConfiguration : IEntityTypeConfiguration<DBHelmet>
{
    public void Configure(EntityTypeBuilder<DBHelmet> builder)
    {
        builder.HasData(new DBHelmet
        {
            Id = 1,
            Name = "Copper Helmet",
            Weight = 3,
            Price = 10,
            SpriteURL = "helmetWarrior0.gif",
            Armor = 5,
            Profession = Profession.Warrior
        }, new DBHelmet
        {
            Id = 2,
            Name = "Wanderer's Hat",
            Weight = 1,
            Price = 2,
            SpriteURL = "helmetHunter0.gif",
            Armor = 1,
            HealthPoints = 5,
            Profession = Profession.Hunter
        }, new DBHelmet
        {
            Id = 3,
            Name = "Magician's Hat",
            Weight = 2,
            Price = 5,
            SpriteURL = "helmetMage0.gif",
            MagicArmor = 10,
            HealthPoints = 10,
            Profession = Profession.Mage
        }, new DBHelmet
        {
            Id = 4,
            Name = "Zinc Helmet",
            Weight = 3,
            Price = 10,
            SpriteURL = "helmetPaladin0.gif",
            Armor = 5,
            MagicArmor = 10,
            Profession = Profession.Paladin
        }, new DBHelmet
        {
            Id = 5,
            Name = "Viking Helmet",
            Level = 10,
            Weight = 7,
            Price = 30,
            SpriteURL = "helmetWarrior10.gif",
            Armor = 40,
            Agility = -5,
            HealthPoints = 15,
            Profession = Profession.Warrior
        }, new DBHelmet
        {
            Id = 6,
            Name = "Elf Hat",
            Level = 10,
            Weight = 2,
            Price = 15,
            SpriteURL = "helmetHunter10.gif",
            Armor = 10,
            Agility = 5,
            HealthPoints = 10,
            Profession = Profession.Hunter
        }, new DBHelmet
        {
            Id = 7,
            Name = "Student Cap",
            Level = 10,
            Weight = 1,
            Price = 5,
            SpriteURL = "helmetMage10.gif",
            MagicArmor = 10,
            HealthPoints = 30,
            Profession = Profession.Mage
        }, new DBHelmet
        {
            Id = 8,
            Name = "Steel Helmet",
            Level = 10,
            Weight = 6,
            Price = 10,
            SpriteURL = "helmetPaladin10.gif",
            Armor = 25,
            MagicArmor = 15,
            HealthPoints = 5,
            Profession = Profession.Paladin
        }, new DBHelmet
        {
            Id = 9,
            Name = "Battle Helmet",
            Level = 20,
            Weight = 6,
            Price = 100,
            SpriteURL = "helmetWarrior20.gif",
            Armor = 30,
            Agility = 5,
            HealthPoints = 15,
            Profession = Profession.Warrior
        }, new DBHelmet
        {
            Id = 10,
            Name = "Agility Hood",
            Level = 20,
            Weight = 2,
            Price = 40,
            SpriteURL = "helmetHunter20.gif",
            Armor = 10,
            Agility = 25,
            HealthPoints = 5,
            Profession = Profession.Hunter
        }, new DBHelmet
        {
            Id = 11,
            Name = "Helmet of Versatility",
            Level = 20,
            Weight = 4,
            Price = 200,
            SpriteURL = "helmetMage20.gif",
            Armor = 15,
            MagicArmor = 15,
            Agility = 5,
            HealthPoints = 15,
            Profession = Profession.Mage
        }, new DBHelmet
        {
            Id = 12,
            Name = "Gilded Helmet",
            Level = 20,
            Weight = 6,
            Price = 100,
            SpriteURL = "helmetPaladin20.gif",
            Armor = 30,
            MagicArmor = 25,
            HealthPoints = 10,
            Profession = Profession.Paladin
        }, new DBHelmet
        {
            Id = 13,
            Name = "Tournament Visor",
            Level = 30,
            Weight = 7,
            Price = 250,
            SpriteURL = "helmetWarrior30.gif",
            Armor = 100,
            Profession = Profession.Warrior
        }, new DBHelmet
        {
            Id = 14,
            Name = "Bear Hat",
            Level = 30,
            Weight = 3,
            Price = 175,
            SpriteURL = "helmetHunter30.gif",
            Armor = 65,
            Agility = 5,
            HealthPoints = 30,
            Profession = Profession.Hunter
        }, new DBHelmet
        {
            Id = 15,
            Name = "Magical Hat Of The Crimson Avenger",
            Level = 30,
            Weight = 2,
            Price = 450,
            SpriteURL = "helmetMage30.gif",
            Armor = 50,
            MagicArmor = 50,
            Agility = 10,
            HealthPoints = 40,
            Profession = Profession.Mage
        }, new DBHelmet
        {
            Id = 16,
            Name = "Helmet Of The Order",
            Level = 30,
            Weight = 5,
            Price = 300,
            SpriteURL = "helmetPaladin30.gif",
            Armor = 85,
            MagicArmor = 45,
            HealthPoints = 35,
            Profession = Profession.Paladin
        });
    }
}
