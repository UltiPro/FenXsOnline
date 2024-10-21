namespace Classes.Exceptions.Game.Hero;

public class HeroLevelTooLowException : Exception
{
    public HeroLevelTooLowException(int minLevel)
        : base($"The hero's level is too low to perform this action. The character must be at least level {minLevel}.")
    { }
}
