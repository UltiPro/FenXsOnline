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
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Name = "Moderator",
                NormalizedName = "MOD"
            },
            new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMIN"
            }
            );
    }
}
