using Classes.Models.Game.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration.Game;

public class DBMap2MobConfiguration : IEntityTypeConfiguration<DBMapMob>
{
    public void Configure(EntityTypeBuilder<DBMapMob> builder)
    {
        builder.HasData(new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 15,
            Y = 25
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 6,
            Y = 22
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 2,
            Y = 21
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 4,
            Y = 18
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 7,
            Y = 17
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 9,
            Y = 20
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 23,
            Y = 24
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 24,
            Y = 22
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 23,
            Y = 19
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 22,
            Y = 14
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 17,
            Y = 12
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 16,
            Y = 19
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 24,
            Y = 10
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 22,
            Y = 7
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 27,
            Y = 9
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 17,
            Y = 5
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 19,
            Y = 8
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 13,
            Y = 4
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 8,
            Y = 6
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 7,
            Y = 11
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 4,
            Y = 8
        }, new DBMapMob
        {
            MapId = 2,
            MobId = 2,
            X = 2,
            Y = 9
        });
    }
}
