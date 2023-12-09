using Classes.Enums.Game;
using Classes.Statics.Game;

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
        switch (Profession)
        {
            case Profession.Warrior:
                if (Sex == Sex.Male) SpriteURL = Sprites.warriorMale[0];
                else SpriteURL = Sprites.warriorFemale[0];
                break;
            case Profession.Hunter:
                if (Sex == Sex.Male) SpriteURL = Sprites.hunterMale[0];
                else SpriteURL = Sprites.hunterFemale[0];
                break;
            case Profession.Mage:
                if (Sex == Sex.Male) SpriteURL = Sprites.mageMale[0];
                else SpriteURL = Sprites.mageFemale[0];
                break;
            case Profession.Paladin:
                if (Sex == Sex.Male) SpriteURL = Sprites.paladinMale[0];
                else SpriteURL = Sprites.paladinFemale[0];
                break;
        }
    }
}
