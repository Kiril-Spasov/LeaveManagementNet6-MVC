using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                    UserId = "0c272e26-4c64-4c1e-bb14-35120c03b52a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                    UserId = "25eeb5c8-c443-4ad7-8732-f2786a730f01"
                }
                );
        }
    }
}