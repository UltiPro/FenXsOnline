using Classes.Enums.Game;
using Classes.Models.Game.Quest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Quest;

public class DBQuestRewardConfiguration : IEntityTypeConfiguration<DBQuestReward>
{
    public void Configure(EntityTypeBuilder<DBQuestReward> builder)
    {
        builder.HasData(new DBQuestReward
        {
            QuestId = 1,
            ItemType = ItemType.Consumables,
            ItemId = 1
        }, new DBQuestReward
        {
            QuestId = 4,
            ItemType = ItemType.Neutral,
            ItemId = 8
        }, new DBQuestReward
        {
            QuestId = 5,
            ItemType = ItemType.Neutral,
            ItemId = 10
        }, new DBQuestReward
        {
            QuestId = 5,
            ItemType = ItemType.Neutral,
            ItemId = 11
        }, new DBQuestReward
        {
            QuestId = 5,
            ItemType = ItemType.Neutral,
            ItemId = 11
        });
    }
}
