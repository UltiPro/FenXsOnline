using Classes.Models.Game.Item.QuestItem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Item;

public class DBQuestItemConfiguration : IEntityTypeConfiguration<DBQuestItem>
{
    public void Configure(EntityTypeBuilder<DBQuestItem> builder)
    {
        builder.HasData(new DBQuestItem
        {
            Id = 1,
            Name = "Alchemist's Book",
            SpriteURL = "alchemistBook.gif",
            Description = "The alchemist's lost book."
        }, new DBQuestItem
        {
            Id = 2,
            Name = "Crystal",
            SpriteURL = "crystal.gif"
        }, new DBQuestItem
        {
            Id = 3,
            Name = "Mysterious Key",
            SpriteURL = "key0.gif",
            Description = "Will you find its destiny?"
        }, new DBQuestItem
        {
            Id = 4,
            Name = "Key To Catacombs",
            SpriteURL = "key1.gif",
            Description = "Allows you to enter the catacombs."
        }, new DBQuestItem
        {
            Id = 5,
            Name = "Healer's Necklace",
            SpriteURL = "healerNecklace.gif",
            Description = "The healer's lost necklace."
        });
    }
}
