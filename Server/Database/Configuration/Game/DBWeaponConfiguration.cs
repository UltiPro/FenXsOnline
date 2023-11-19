using Classes.Enums.Game;
using Classes.Models.Game.Item.Weapon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBWeaponConfiguration : IEntityTypeConfiguration<DBWeapon>
{
    public void Configure(EntityTypeBuilder<DBWeapon> builder)
    {
        builder.HasData(new DBWeapon
        {
            Id = 1,
            Name = "Beginner's Sword",
            Weight = 5,
            Price = 10,
            SpriteURL = "primaryWarrior0.gif",
            Atack = 20,
            Profession = Profession.Warrior
        }, new DBWeapon
        {
            Id = 2,
            Name = "Slingshot",
            Weight = 3,
            Price = 10,
            SpriteURL = "primaryHunter0.gif",
            Atack = 10,
            Profession = Profession.Hunter
        }, new DBWeapon
        {
            Id = 3,
            Name = "Beginner's Staff",
            Weight = 4,
            Price = 10,
            SpriteURL = "primaryMage0.gif",
            MagicAtack = 15,
            Profession = Profession.Mage
        }, new DBWeapon
        {
            Id = 4,
            Name = "Blunt Sword",
            Weight = 5,
            Price = 10,
            SpriteURL = "primaryPaladin0.gif",
            Atack = 15,
            MagicAtack = 5,
            Profession = Profession.Paladin
        }, new DBWeapon
        {
            Id = 5,
            Name = "Sword Of Glory",
            Level = 10,
            Weight = 7,
            Price = 50,
            SpriteURL = "primaryWarrior10.gif",
            Atack = 40,
            Profession = Profession.Warrior
        }, new DBWeapon
        {
            Id = 6,
            Name = "Recurve Bow",
            Level = 10,
            Weight = 4,
            Price = 50,
            SpriteURL = "primaryHunter10.gif",
            Atack = 25,
            CriticalChance = 5,
            Profession = Profession.Hunter
        }, new DBWeapon
        {
            Id = 7,
            Name = "Staff of Serpents",
            Level = 10,
            Weight = 5,
            Price = 50,
            SpriteURL = "primaryMage10.gif",
            MagicAtack = 30,
            CriticalChance = 2,
            Profession = Profession.Mage
        }, new DBWeapon
        {
            Id = 8,
            Name = "Broad sword",
            Level = 10,
            Weight = 8,
            Price = 50,
            SpriteURL = "primaryPaladin10.gif",
            Atack = 30,
            MagicAtack = 15,
            Profession = Profession.Paladin
        }, new DBWeapon
        {
            Id = 9,
            Name = "Victors' Saber",
            Level = 20,
            Weight = 8,
            Price = 150,
            SpriteURL = "primaryWarrior20.gif",
            Atack = 80,
            CriticalChance = 2,
            Profession = Profession.Warrior
        }, new DBWeapon
        {
            Id = 10,
            Name = "Orc Bow",
            Level = 20,
            Weight = 5,
            Price = 150,
            SpriteURL = "primaryHunter20.gif",
            Atack = 55,
            CriticalChance = 10,
            Profession = Profession.Hunter
        }, new DBWeapon
        {
            Id = 11,
            Name = "Staff of the Woods",
            Level = 20,
            Weight = 7,
            Price = 150,
            SpriteURL = "primaryMage20.gif",
            MagicAtack = 60,
            CriticalChance = 5,
            Profession = Profession.Mage
        }, new DBWeapon
        {
            Id = 12,
            Name = "Upgraded Broad sword",
            Level = 20,
            Weight = 9,
            Price = 150,
            SpriteURL = "primaryPaladin20.gif",
            Atack = 70,
            MagicAtack = 5,
            CriticalChance = 5,
            Profession = Profession.Paladin
        }, new DBWeapon
        {
            Id = 13,
            Name = "Sword Of Darkness",
            Level = 30,
            Weight = 8,
            Price = 350,
            SpriteURL = "primaryWarrior30.gif",
            Atack = 120,
            CriticalChance = 5,
            Profession = Profession.Warrior
        }, new DBWeapon
        {
            Id = 14,
            Name = "Bow Of Darkness",
            Level = 30,
            Weight = 6,
            Price = 350,
            SpriteURL = "primaryHunter30.gif",
            Atack = 70,
            CriticalChance = 15,
            Profession = Profession.Hunter
        }, new DBWeapon
        {
            Id = 15,
            Name = "Staff of the Order",
            Level = 30,
            Weight = 7,
            Price = 350,
            SpriteURL = "primaryMage30.gif",
            MagicAtack = 90,
            CriticalChance = 5,
            Profession = Profession.Mage
        }, new DBWeapon
        {
            Id = 16,
            Name = "Sword of the Order",
            Level = 30,
            Weight = 8,
            Price = 350,
            SpriteURL = "primaryPaladin30.gif",
            Atack = 110,
            MagicAtack = 40,
            Profession = Profession.Paladin
        });
    }
}
