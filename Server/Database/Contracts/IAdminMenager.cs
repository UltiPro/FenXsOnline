using Classes.Models.Admin;

namespace Database.Contracts;

public interface IAdminMenager
{
    Task<bool> SetAdminByCode(AdminSetByCode adminSetByCode);
    Task<bool> SetAdmin(string id);
    Task<bool> UnsetAdmin(string id);
    Task<bool> SetModerator(string id);
    Task<bool> UnsetModerator(string id);
    Task<bool> BanUser(string id);
    Task<bool> UnbanUser(string id);
}
