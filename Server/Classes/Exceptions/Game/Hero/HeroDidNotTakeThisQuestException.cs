﻿namespace Classes.Exceptions.Game.Hero;

public class HeroDidNotTakeThisQuestException : Exception
{
    public HeroDidNotTakeThisQuestException() : base("Hero did not take this quest.") { }
}
