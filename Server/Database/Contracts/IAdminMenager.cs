using Classes.Models.Admin;

namespace Database.Contracts;

public interface IAdminMenager
{
    Task SetAdminByCode(AdminSetByCode adminSetByCode);
    Task SetAdmin(string id);
    Task UnsetAdmin(string id);
    Task SetModerator(string id);
    Task UnsetModerator(string id);
    Task BanUser(string id);
    Task UnbanUser(string id);
}
