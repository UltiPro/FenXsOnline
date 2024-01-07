namespace Classes.Exceptions.Game.Hero;

public class HeroEquipmentSlotIsEmptyException : Exception
{
    public HeroEquipmentSlotIsEmptyException() : base("There is no item in this slot.") { }
}
