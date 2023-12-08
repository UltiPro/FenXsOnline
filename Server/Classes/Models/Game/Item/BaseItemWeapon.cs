namespace Classes.Models.Game.Item;

public class BaseItemWeapon : BaseItemWornableProfession
{
    public int Atack { get; set; } = 0;
    public int MagicAtack { get; set; } = 0;
    public int CriticalChance { get; set; } = 0;
}
