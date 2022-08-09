using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }
                );
        }
    }
}