using Classes.Statics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> entityTypeBuilder)
    {
        entityTypeBuilder.HasData(
            new IdentityRole
            {
                Name = Role.User,
                NormalizedName = Role.User.ToUpper()
            },
            new IdentityRole
            {
                Name = Role.Mod,
                NormalizedName = Role.Mod.ToUpper()
            },
            new IdentityRole
            {
                Name = Role.Admin,
                NormalizedName = Role.Admin.ToUpper()
            }
            );
    }
}
