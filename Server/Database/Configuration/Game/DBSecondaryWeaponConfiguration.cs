using Classes.Enums.Game;
using Classes.Models.Game.Item.SecondaryWeapon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBSecondaryWeaponConfiguration : IEntityTypeConfiguration<DBSecondaryWeapon>
{
    public void Configure(EntityTypeBuilder<DBSecondaryWeapon> builder)
    {
        builder.HasData(new DBSecondaryWeapon
        {
            Id = 1,
            Name = "Round Wooden Shield",
            Weight = 5,
            Price = 10,
            SpriteURL = "secondaryWarrior0.gif",
            Armor = 20,
            Profession = Profession.Warrior
        }, new DBSecondaryWeapon
        {
            Id = 2,
            Name = "Arrow",
            Weight = 1,
            Price = 1,
            SpriteURL = "secondaryHunter0.gif",
            Atack = 5,
            Profession = Profession.Hunter
        }, new DBSecondaryWeapon
        {
            Id = 3,
            Name = "School Spell Book",
            Weight = 2,
            Price = 5,
            SpriteURL = "secondaryMage0.gif",
            CriticalChance = 3,
            Profession = Profession.Mage
        }, new DBSecondaryWeapon
        {
            Id = 4,
            Name = "Beginner's Shield",
            Weight = 5,
            Price = 10,
            SpriteURL = "secondaryPaladin0.gif",
            Armor = 10,
            MagicArmor = 5,
            Profession = Profession.Paladin
        }, new DBSecondaryWeapon
        {
            Id = 5,
            Name = "Knight's Shield",
            Level = 10,
            Weight = 5,
            Price = 20,
            SpriteURL = "secondaryWarrior10.gif",
            CriticalChance = 2,
            Armor = 40,
            Profession = Profession.Warrior
        }, new DBSecondaryWeapon
        {
            Id = 6,
            Name = "Fire Arrow",
            Level = 10,
            Weight = 1,
            Price = 2,
            SpriteURL = "secondaryHunter10.gif",
            Atack = 10,
            CriticalChance = 5,
            Profession = Profession.Hunter
        }, new DBSecondaryWeapon
        {
            Id = 7,
            Name = "Book Of Spells",
            Level = 10,
            Weight = 2,
            Price = 10,
            SpriteURL = "secondaryMage10.gif",
            MagicAtack = 5,
            CriticalChance = 7,
            Profession = Profession.Mage
        }, new DBSecondaryWeapon
        {
            Id = 8,
            Name = "Friar's Shield",
            Level = 10,
            Weight = 5,
            Price = 25,
            SpriteURL = "secondaryPaladin10.gif",
            CriticalChance = 2,
            Armor = 15,
            MagicArmor = 15,
            Profession = Profession.Paladin
        }, new DBSecondaryWeapon
        {
            Id = 9,
            Name = "Shield Of The Damned",
            Level = 20,
            Weight = 6,
            Price = 50,
            SpriteURL = "secondaryWarrior20.gif",
            CriticalChance = 5,
            Armor = 65,
            Profession = Profession.Warrior
        }, new DBSecondaryWeapon
        {
            Id = 10,
            Name = "Poisoned Arrow",
            Level = 20,
            Weight = 1,
            Price = 20,
            SpriteURL = "secondaryHunter20.gif",
            Atack = 25,
            CriticalChance = 5,
            Profession = Profession.Hunter
        }, new DBSecondaryWeapon
        {
            Id = 11,
            Name = "The Sorcerer's Book",
            Level = 20,
            Weight = 3,
            Price = 100,
            SpriteURL = "secondaryMage20.gif",
            MagicAtack = 50,
            CriticalChance = 2,
            Profession = Profession.Mage
        }, new DBSecondaryWeapon
        {
            Id = 12,
            Name = "Shield Of The Order",
            Level = 20,
            Weight = 6,
            Price = 75,
            SpriteURL = "secondaryPaladin20.gif",
            CriticalChance = 3,
            Armor = 25,
            MagicArmor = 25,
            Profession = Profession.Paladin
        });
    }
}
