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
using Database.Configuration.Game;
using Classes.Models.Game.Item.Consumables;
using Classes.Models.Game.Item.Neutral;
using Classes.Models.Game.Item.QuestItem;
using Classes.Models.Game.Mob;

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
    public DbSet<DBConsumables> Consumables { get; set; }
    public DbSet<DBNeutral> Neutrals { get; set; }
    public DbSet<DBQuestItem> QuestItems { get; set; }
    public DbSet<DBHeroEquipment> HeroesEquipments { get; set; }
    public DbSet<DBMob> Mobs { get; set; }
    public DbSet<DBMobDrop> MobsDrop { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new RoleConfiguration());

        modelBuilder.ApplyConfiguration(new DBArmorConfiguration());
        modelBuilder.ApplyConfiguration(new DBBootsConfiguration());
        modelBuilder.ApplyConfiguration(new DBGlovesConfiguration());
        modelBuilder.ApplyConfiguration(new DBHelmetConfiguration());
        modelBuilder.ApplyConfiguration(new DBNecklaceConfiguration());
        modelBuilder.ApplyConfiguration(new DBRingConfiguration());
        modelBuilder.ApplyConfiguration(new DBSecondaryWeaponConfiguration());
        modelBuilder.ApplyConfiguration(new DBWeaponConfiguration());

        modelBuilder.ApplyConfiguration(new DBConsumablesConfiguration());
        modelBuilder.ApplyConfiguration(new DBNeutralConfiguration());
        modelBuilder.ApplyConfiguration(new DBQuestItemConfiguration());

        modelBuilder.ApplyConfiguration(new DBMobConfiguration());
        modelBuilder.ApplyConfiguration(new DBMobDropConfiguration());

        modelBuilder.Entity<DBHero>().HasIndex(hero => hero.Name).IsUnique();
        modelBuilder.Entity<DBHeroEquipment>().HasKey(heroEquipment => new { heroEquipment.HeroId, heroEquipment.Id });
    }
}
