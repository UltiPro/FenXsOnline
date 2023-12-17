using Classes.Models.Game.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBMap1MobConfiguration : IEntityTypeConfiguration<DBMapMob>
{
    public void Configure(EntityTypeBuilder<DBMapMob> builder)
    {
        builder.HasData(new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 12,
            Y = 88
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 16,
            Y = 89
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 19,
            Y = 83
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 5,
            Y = 86
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 26,
            Y = 91
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 29,
            Y = 94
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 9,
            Y = 66
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 1,
            Y = 43
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 3,
            Y = 39
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 6,
            Y = 46
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 1,
            Y = 50
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 6,
            Y = 51
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 1,
            Y = 61
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 40,
            Y = 93
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 40,
            Y = 89
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 57,
            Y = 94
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 54,
            Y = 92
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 53,
            Y = 94
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 47,
            Y = 92
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 48,
            Y = 88
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 42,
            Y = 73
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 47,
            Y = 73
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 51,
            Y = 75
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 58,
            Y = 67
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 53,
            Y = 65
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 59,
            Y = 65
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 61,
            Y = 62
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 58,
            Y = 63
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 55,
            Y = 63
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 52,
            Y = 60
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 57,
            Y = 61
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 59,
            Y = 61
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 61,
            Y = 60
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 62,
            Y = 57
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 59,
            Y = 58
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 59,
            Y = 53
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 59,
            Y = 27
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 55,
            Y = 25
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 53,
            Y = 26
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 62,
            Y = 20
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 55,
            Y = 19
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 53,
            Y = 12
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 55,
            Y = 13
        }, new DBMapMob
        {
            MapId = 1,
            MobId = 1,
            X = 57,
            Y = 9
        });
    }
}
