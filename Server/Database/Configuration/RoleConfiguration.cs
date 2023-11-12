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
                Name = Roles.User,
                NormalizedName = Roles.UserN
            },
            new IdentityRole
            {
                Name = Roles.Mod,
                NormalizedName = Roles.ModN
            },
            new IdentityRole
            {
                Name = Roles.Admin,
                NormalizedName = Roles.AdminN
            }
            );
    }
}
