using Classes.Enums.Game;
using System.ComponentModel.DataAnnotations;

namespace Classes.Models.Game.Hero;

public class HeroCreate : HeroName
{
    [Required(ErrorMessage = "Hero profession is required.")]
    [Range(0, 3)]
    public Profession Profession { get; set; }
    [Required(ErrorMessage = "Hero sex is required.")]
    [Range(0, 1)]
    public Sex Sex { get; set; }
}
