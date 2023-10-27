using AutoMapper;
using Classes.Models.User;

namespace Database.Configuration;

public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        CreateMap<UserRegister, DBUser>().ReverseMap();
    }
}
