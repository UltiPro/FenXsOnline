using Classes.Enums.Game;

namespace Classes.Models.Game.Hero;

public class HeroCreateBackend : HeroCreate
{
    public string UserId { get; set; }
    public string SpriteURL { get; set; }
    public HeroCreateBackend(HeroCreate heroCreate, string userId)
    {
        Name = heroCreate.Name;
        Profession = heroCreate.Profession;
        Sex = heroCreate.Sex;
        UserId = userId;
        switch (Sex)
        {
            case Sex.Male:
                switch (Profession)
                {
                    case Profession.Warrior:
                        if (Sex == Sex.Male) SpriteURL = "warriorM0.gif";
                        else SpriteURL = "warriorF0.gif";
                        break;
                    case Profession.Hunter:
                        if (Sex == Sex.Male) SpriteURL = "hunterM0.gif";
                        else SpriteURL = "hunterF0.gif";
                        break;
                    case Profession.Mage:
                        if (Sex == Sex.Male) SpriteURL = "mageM0.gif";
                        else SpriteURL = "mageF0.gif";
                        break;
                    case Profession.Paladin:
                        if (Sex == Sex.Male) SpriteURL = "paladinM0.gif";
                        else SpriteURL = "paladinF0.gif";
                        break;
                }
                break;
        }
    }
}
