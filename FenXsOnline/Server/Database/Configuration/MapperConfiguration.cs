using AutoMapper;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Map;
using Classes.Models.Game.Mob;
using Classes.Models.Game.Npc;
using Classes.Models.Game.Quest;
using Classes.Models.User;

namespace Database.Configuration;

public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        CreateMap<UserRegister, DBUser>().ReverseMap();
        CreateMap<HeroCreateBackend, DBHero>().ReverseMap();
        CreateMap<HeroBasicInfo, DBHero>().ReverseMap();
        CreateMap<MapHero, DBHero>().ReverseMap();
        CreateMap<MapData, MapDataResponse>().ReverseMap();
        CreateMap<MapData, MapDataRefresh>().ReverseMap();
        CreateMap<MapDoor, MapPosition>().ReverseMap();
        CreateMap<MobProvider, DBMob>().ReverseMap();
        CreateMap<NpcQuestResponse, DBNpc>().ReverseMap();
        CreateMap<QuestResponse, DBQuest>().ReverseMap();
        CreateMap<QuestStageResponse, DBQuest>().ReverseMap();
        CreateMap<QuestNpcMessage, DBQuestStage>().ReverseMap();
    }
}
