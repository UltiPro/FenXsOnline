using Microsoft.AspNetCore.Identity;
using Classes.Models.Game.Hero;

namespace Classes.Models.User;

public class DBUser : IdentityUser
{
    public bool IsBanned { get; set; } = false;
    public virtual IList<DBHero> Heroes { get; set; }
}
