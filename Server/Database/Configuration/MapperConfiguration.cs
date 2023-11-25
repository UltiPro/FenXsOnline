using AutoMapper;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Map;
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
    }
}
