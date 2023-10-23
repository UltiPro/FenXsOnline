using Microsoft.AspNetCore.Identity;
using Classes.Models.Hero;

namespace Classes.Models.User;

public class DBUser : IdentityUser
{
    public bool IsBanned { get; set; }
    public virtual IList<DBHero> Heros { get; set; }
}
