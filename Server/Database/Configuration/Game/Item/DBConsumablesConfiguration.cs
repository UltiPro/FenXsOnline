using Classes.Models.Game.Item.Consumables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Item;

public class DBConsumablesConfiguration : IEntityTypeConfiguration<DBConsumables>
{
    public void Configure(EntityTypeBuilder<DBConsumables> builder)
    {
        builder.HasData(new DBConsumables
        {
            Id = 1,
            Name = "Small Health Potion",
            SpriteURL = "potionHealthSmall.gif",
            HealthPoints = 10,
            Price = 20
        }, new DBConsumables
        {
            Id = 2,
            Name = "Small Stamina Potion",
            SpriteURL = "potionStaminaSmall.gif",
            Stamina = 10,
            Price = 50
        }, new DBConsumables
        {
            Id = 3,
            Name = "Small Mana Potion",
            SpriteURL = "potionManaSmall.gif",
            Mana = 10,
            Price = 50
        }, new DBConsumables
        {
            Id = 4,
            Name = "Medium Health Potion",
            SpriteURL = "potionHealthMedium.gif",
            HealthPoints = 30,
            Price = 100
        }, new DBConsumables
        {
            Id = 5,
            Name = "Medium Stamina Potion",
            SpriteURL = "potionStaminaMedium.gif",
            Stamina = 30,
            Price = 200
        }, new DBConsumables
        {
            Id = 6,
            Name = "Medium Mana Potion",
            SpriteURL = "potionManaMedium.gif",
            Mana = 30,
            Price = 200
        }, new DBConsumables
        {
            Id = 7,
            Name = "Large Health Potion",
            SpriteURL = "potionHealthLarge.gif",
            HealthPoints = 100,
            Price = 1000
        }, new DBConsumables
        {
            Id = 8,
            Name = "Large Stamina Potion",
            SpriteURL = "potionStaminaLarge.gif",
            Stamina = 100,
            Price = 2000
        }, new DBConsumables
        {
            Id = 9,
            Name = "Large Mana Potion",
            SpriteURL = "potionManaLarge.gif",
            Mana = 100,
            Price = 2000
        }, new DBConsumables
        {
            Id = 10,
            Name = "Apple",
            SpriteURL = "apple.gif",
            HealthPoints = 2,
            Price = 3
        }, new DBConsumables
        {
            Id = 11,
            Name = "Meat",
            SpriteURL = "meat.gif",
            HealthPoints = 5,
            Price = 8
        }, new DBConsumables
        {
            Id = 12,
            Name = "Night Mashroom",
            SpriteURL = "nightMashroom.gif",
            Stamina = 5,
            Mana = 5,
            HealthPoints = -10,
            Price = 5
        }, new DBConsumables
        {
            Id = 13,
            Name = "Pile Of Coins",
            SpriteURL = "pileOfCoins.gif",
            Gold = 15,
            Price = 0
        });
    }
}
