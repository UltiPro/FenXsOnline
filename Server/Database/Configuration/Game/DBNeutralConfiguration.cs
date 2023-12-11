using Classes.Models.Game.Item.Neutral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBNeutralConfiguration : IEntityTypeConfiguration<DBNeutral>
{
    public void Configure(EntityTypeBuilder<DBNeutral> builder)
    {
        builder.HasData(new DBNeutral
        {
            Id = 1,
            Name = "Feather",
            SpriteURL = "feather.gif",
            Price = 5
        }, new DBNeutral
        {
            Id = 2,
            Name = "Boar Leather",
            SpriteURL = "boarLeather.gif",
            Price = 25
        }, new DBNeutral
        {
            Id = 3,
            Name = "Boar Tusk",
            SpriteURL = "boarTusk.gif",
            Price = 10
        }, new DBNeutral
        {
            Id = 4,
            Name = "Boar Tail",
            SpriteURL = "boarTail.gif",
            Price = 5
        }, new DBNeutral
        {
            Id = 5,
            Name = "Wolf Tusk",
            SpriteURL = "wolfTusk.gif",
            Price = 15
        }, new DBNeutral
        {
            Id = 6,
            Name = "Spider Poison",
            SpriteURL = "spiderPoison.gif",
            Price = 50,
            Description = "Strong poison, some craftsmen may be interested in it."
        }, new DBNeutral
        {
            Id = 7,
            Name = "Powder",
            SpriteURL = "powder.gif",
            Price = 5,
            Description = "Wonder if it can be useful for something?"
        }, new DBNeutral
        {
            Id = 8,
            Name = "Jasper",
            SpriteURL = "jasper.gif",
            Price = 150,
            Description = "Rare expensive stone."
        }, new DBNeutral
        {
            Id = 9,
            Name = "Cloth",
            SpriteURL = "cloth.gif",
            Price = 5
        }, new DBNeutral
        {
            Id = 10,
            Name = "Wood",
            SpriteURL = "wood.gif",
            Price = 100
        }, new DBNeutral
        {
            Id = 11,
            Name = "Iron Nuggets",
            SpriteURL = "ironNuggets.gif",
            Price = 200,
            Description = "Raw material."
        }, new DBNeutral
        {
            Id = 12,
            Name = "Iron Ingot",
            SpriteURL = "ironIngot.gif",
            Price = 1000,
            Description = "Useful in crafts."
        }, new DBNeutral
        {
            Id = 13,
            Name = "Blue Crystal",
            SpriteURL = "blueCrystal.gif",
            Price = 350,
            Description = "Precious item."
        }, new DBNeutral
        {
            Id = 14,
            Name = "Trinket",
            SpriteURL = "trinket.gif",
            Price = 500,
            Description = "Wonder who it belonged to?"
        }, new DBNeutral
        {
            Id = 15,
            Name = "Shell",
            SpriteURL = "shell.gif",
            Price = 100,
            Description = "Wonder what's inside?"
        }, new DBNeutral
        {
            Id = 16,
            Name = "Pearl",
            SpriteURL = "pearl.gif",
            Price = 2500,
            Description = "Precious find in one of the shells."
        }, new DBNeutral
        {
            Id = 17,
            Name = "Blood Pearl",
            SpriteURL = "bloodPearl.gif",
            Price = 5000,
            Description = "Precious find in one of the shells. " +
            "Legend has it that the red color of the pearl comes " +
            "from the blood of the king murdered by his subordinates."
        });
    }
}
