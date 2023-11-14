using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Database.Configuration;
using Classes.Models.User;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;

namespace Database;

public class DatabaseContext : IdentityDbContext<DBUser>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public override DbSet<DBUser> Users { get; set; }
    public DbSet<DBHero> Heroes { get; set; }
    public DbSet<DBArmor> Armors { get; set; }
    public DbSet<DBBoots> Boots { get; set; }
    public DbSet<DBGloves> Gloves { get; set; }
    public DbSet<DBHelmet> Helmets { get; set; }
    public DbSet<DBNecklace> Necklaces { get; set; }
    public DbSet<DBRing> Rings { get; set; }
    public DbSet<DBSecondaryWeapon> SecondaryWeapons { get; set; }
    public DbSet<DBWeapon> Weapons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new RoleConfiguration());
    }
}
