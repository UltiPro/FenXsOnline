using Classes.Enums.Game;
using System.ComponentModel.DataAnnotations;

namespace Classes.Models.Game.Hero;

public class HeroCreate
{
    [Required(ErrorMessage = "Hero name is required.")]
    [RegularExpression(@"^(^[^0-9])([\w a-z A-Z 0-9-_]{2,14})$", ErrorMessage = "A nickname cannot be shorter than 3 characters and longer than 15 characters.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Hero profession is required.")]
    [Range(0, 3)]
    public Profession Profession { get; set; }
    [Required(ErrorMessage = "Hero sex is required.")]
    [Range(0, 1)]
    public Sex Sex { get; set; }
}
