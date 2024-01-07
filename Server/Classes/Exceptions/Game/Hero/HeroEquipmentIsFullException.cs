namespace Classes.Exceptions.Game.Hero;

public class HeroEquipmentIsFullException : Exception
{
    public HeroEquipmentIsFullException() : base("Hero equipment is full.") { }
}
