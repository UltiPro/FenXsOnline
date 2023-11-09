using Classes.Models.Game.Hero;
using Microsoft.AspNetCore.Identity;

namespace Classes.Models.User;

public class DBUser : IdentityUser
{
    public bool IsBanned { get; set; }
    public virtual IList<DBHero> Heroes { get; set; }
}