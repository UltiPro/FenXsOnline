using Classes.Enums.Game;
using Classes.Models.Game.Quest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Quest;

public class DBQuestStageConfiguration : IEntityTypeConfiguration<DBQuestStage>
{
    public void Configure(EntityTypeBuilder<DBQuestStage> builder)
    {
        builder.HasData(new DBQuestStage
        {
            QuestId = 1,
            Stage = 1,
            Description = "Find the healer's necklace and bring it to her.",
            NpcId = 1,
            NpcMessage = "I found your necklace.",
            NpcAnswear = "Thank you very much, here is your reward.",
            Bring = true,
            ItemType = ItemType.ToQuest,
            ItemId = 5,
            Quantity = 1
        }, new DBQuestStage
        {
            QuestId = 2,
            Stage = 1,
            Description = "Kill 30 rabbits.",
            Kill = true,
            MobId = 1,
            Quantity = 30
        }, new DBQuestStage
        {
            QuestId = 2,
            Stage = 2,
            Description = "Tell Eldrik that you have killed enough rabbits.",
            Talk = true,
            NpcId = 2,
            NpcMessage = "I killed rabbits.",
            NpcAnswear = "Thank you very much, here is your reward."
        }, new DBQuestStage
        {
            QuestId = 3,
            Stage = 1,
            Description = "Kill 30 spiders.",
            Kill = true,
            MobId = 2,
            Quantity = 30
        }, new DBQuestStage
        {
            QuestId = 3,
            Stage = 2,
            Description = "Tell Franko that you have killed enough spiders.",
            Talk = true,
            NpcId = 4,
            NpcMessage = "I killed spiders.",
            NpcAnswear = "Thank you very much, here is your reward."
        }, new DBQuestStage
        {
            QuestId = 4,
            Stage = 1,
            Description = "Bring 3 apples for cake to Adelaide.",
            NpcId = 1,
            NpcMessage = "I brought you three apples.",
            NpcAnswear = "Thank you very much, here is your reward.",
            Bring = true,
            ItemType = ItemType.Consumables,
            ItemId = 10,
            Quantity = 3
        }, new DBQuestStage
        {
            QuestId = 5,
            Stage = 1,
            Description = "Bring 5 night mashroom to Gustaf.",
            NpcId = 3,
            NpcMessage = "I brought you five night mashrooms.",
            NpcAnswear = "Thank you very much, here is your reward.",
            Bring = true,
            ItemType = ItemType.Consumables,
            ItemId = 12,
            Quantity = 5
        });
    }
}
