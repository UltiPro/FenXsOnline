namespace Classes.Exceptions.Game;

public class HeroEquipmentSlotIsOccupiedException : Exception
{
    public HeroEquipmentSlotIsOccupiedException() : base("This slot is occupied.") { }
}
