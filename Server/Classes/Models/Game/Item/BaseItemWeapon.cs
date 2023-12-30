namespace Classes.Models.Game.Item;

public class BaseItemWeapon : BaseItemWornableProfession
{
    public int Attack { get; set; } = 0;
    public int MagicAttack { get; set; } = 0;
    public int CriticalChance { get; set; } = 0;
}
