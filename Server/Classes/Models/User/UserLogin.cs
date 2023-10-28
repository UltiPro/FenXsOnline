using System.ComponentModel.DataAnnotations;

namespace Classes.Models.User;

public class UserLogin
{
    [Required(ErrorMessage = "Login is required.")]
    [RegularExpression(@"^(?=.*?[a-zA-Z\d])[a-zA-Z][a-zA-Z\d_-]{2,28}[a-zA-Z\d]$", ErrorMessage = "The login must be between 4 and 30 characters long and must start with a letter and end with a letter or number. May contain a floor and a dash between the start and end.")]
    public string Login { get; set; }
    [Required(ErrorMessage = "Password is required.")]
    [RegularExpression(@"^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[.~!@#$%^&*()+=[\]\\;:'""/,|{}<>?])\S{8,40}$", ErrorMessage = "Password must be between 8 and 40 characters long and contain at least one lowercase letter, one uppercase letter, one number and one special character.")]
    public string Password { get; set; }
}
