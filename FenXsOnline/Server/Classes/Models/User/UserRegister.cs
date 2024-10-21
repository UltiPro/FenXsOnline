using System.ComponentModel.DataAnnotations;

namespace Classes.Models.User;

public class UserRegister : UserLogin
{
    [Required]
    [EmailAddress(ErrorMessage = "Incorrect e-mail address.")]
    public string Email { get; set; }
}
