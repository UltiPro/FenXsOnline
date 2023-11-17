using System.ComponentModel.DataAnnotations;

namespace Classes.Models.Game.Hero;

public class HeroName
{
    [Required(ErrorMessage = "Hero name is required.")]
    [RegularExpression(@"^[a-zA-Z]\w{2,15}$", ErrorMessage = "A nickname cannot be shorter than 3 characters and longer than 15 characters.")]
    public string Name { get; set; }
}
