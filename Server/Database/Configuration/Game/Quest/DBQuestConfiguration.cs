using Classes.Models.Game.Quest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game.Quest;

public class DBQuestConfiguration : IEntityTypeConfiguration<DBQuest>
{
    public void Configure(EntityTypeBuilder<DBQuest> builder)
    {
        builder.HasData(new DBQuest
        {
            Id = 1,
            Title = "The healer's lost necklace.",
            NpcId = 1,
            NpcMessage = "I lost my necklace somewhere around here, could you find it and bring it back to me please?",
            Gold = 100
        }, new DBQuest
        {
            Id = 2,
            Title = "Rabbit plague.",
            NpcId = 2,
            NpcMessage = "There are too many rabbits in the area, they are destroying crops, can you take care of it?",
            Level = 3,
            Gold = 300
        }, new DBQuest
        {
            Id = 3,
            Title = "Spider plague.",
            NpcId = 4,
            NpcMessage = "There are too many spiders in the near cave, they are so scary, can you take care of it?",
            Level = 5,
            Gold = 300
        }, new DBQuest
        {
            Id = 4,
            Title = "Apple pie.",
            NpcId = 1,
            NpcMessage = "I need 3 apples for a delicious apple cake, could you deliver them to me?",
            Level = 7,
            Gold = 500
        }, new DBQuest
        {
            Id = 5,
            Title = "Mysterious mushrooms.",
            NpcId = 3,
            NpcMessage = "I would like to examine mushrooms from a nearby cave, could you provide them to me?",
            Level = 9,
            Gold = 500
        });
    }
}
