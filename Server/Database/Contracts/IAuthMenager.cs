using Classes.Models;
using Classes.Models.User;
using Microsoft.AspNetCore.Identity;

namespace Database.Contracts;

public interface IAuthMenager
{
    Task<IEnumerable<IdentityError>> Register(UserRegister userRegister);
    Task<AuthResponse> Login(UserLogin userLogin);
    Task<string> RefreshToken();
    Task<AuthResponse> VerifyRefreshToken(AuthResponse authResponse);
}
