using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "7ccc88ed-d354-41f3-ab46-8a7abb016154");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "839a5323-049a-4ab3-94b7-c9eb0bc649b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c93f2ada-c4a8-44b3-b2c8-08061ca0d0e9", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEOWmHFVKFt9laNBAqV2XMHeCoGw30j2IFejfS/nAQbDWBkapOHxBSD7xi8riiU5TDw==", "7b3de131-2199-444e-92cc-e1966ed898a5", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8f78979e-dc5e-40f8-9514-c1a8b21c9068", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAEK+ZWG88uv18PYIIo20KMBOHehMgcHRqzSUJxkbtvPkhBdzzxOifz86BcQ/5oHLM3Q==", "2ddf32a2-bc5e-4232-8d5a-23f2a5b44d32", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "934f5eb5-e0de-4322-a71b-2c7f72b279dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "2c50791a-dc14-46de-bf7b-e354bbfbf227");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e3c7612d-c1fe-4b48-bb75-248dc8fb405e", false, null, "AQAAAAEAACcQAAAAECFrXdnUrLxFaPiAbuFLR7bfekI7suEjzMSREex6D+Ec+hBVPjCiqRjtOh31PLDdNQ==", "92f4f9d3-b61b-4d1b-b56d-f8f18b9b3aa1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "50f0b224-e32e-48c4-923e-14b5999cb8fe", false, null, "AQAAAAEAACcQAAAAEGaKuP9pHR4pesQSlMKTilQMWWWJ+J79+rqpurQ9P5NtRFaoGC8YQHSIgAVK6bGnBQ==", "714c6ee1-e813-4e99-b95f-53c6670113a8", null });
        }
    }
}
