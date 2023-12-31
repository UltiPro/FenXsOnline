﻿using System.ComponentModel.DataAnnotations.Schema;
using Classes.Models.Game.Hero;

namespace Classes.Models.Game.Quest;

public class DBHeroQuest
{
    public int HeroId { get; set; }
    [ForeignKey("HeroId")]
    public DBHero DBHero { get; set; }
    public int QuestId { get; set; }
    [ForeignKey("QuestId")]
    public DBQuest DBQuest { get; set; }
    public bool Done { get; set; } = false;
    public int Stage { get; set; } = 1;
    public int Quantity { get; set; } = 0;
}
