namespace Classes.Exceptions.Game;

public class HeroEquipmentIsFullException : Exception
{
    public HeroEquipmentIsFullException() : base("Hero equipment is full.") { }
}
