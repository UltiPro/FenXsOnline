namespace Classes.Models.Game.Mob;

public class DBMob : MobProvider
{
    public int HealthPoints { get; set; } = 100;
    public int Attack { get; set; } = 1;
    public int MagicAttack { get; set; } = 0;
    public int CriticalChance { get; set; } = 0;
    public int Armor { get; set; } = 0;
    public int MagicArmor { get; set; } = 0;
    public int Agility { get; set; } = 0;
    public int Weight { get; set; } = 1;
    public int DropChance { get; set; } = 50;
    public ICollection<DBMobDrop>? DropItems { get; set; } = null;
}
