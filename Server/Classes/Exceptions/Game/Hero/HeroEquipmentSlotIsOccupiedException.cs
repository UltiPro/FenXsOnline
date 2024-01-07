namespace Classes.Exceptions.Game.Hero;

public class HeroEquipmentSlotIsOccupiedException : Exception
{
    public HeroEquipmentSlotIsOccupiedException() : base("This slot is occupied.") { }
}
