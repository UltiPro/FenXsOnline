namespace Classes.Exceptions.Game;

public class HeroEquipmentSlotIsEmptyException : Exception
{
    public HeroEquipmentSlotIsEmptyException() : base("There is no item in this slot.") { }
}
