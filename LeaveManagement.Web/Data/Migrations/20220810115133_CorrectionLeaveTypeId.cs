using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class CorrectionLeaveTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "1247e0c5-5e43-4dd6-8615-a1cc8e8cbb7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "53db3f5e-83e8-4cc9-b2df-88dae514e137");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b375494-b55a-4e9d-81a8-acebcbda88d6", "AQAAAAEAACcQAAAAEAWp8gkFA++64Ps/D97Bv1CStR2TdfWPWkwn/zrRP3fPaT0nPbcvY0H8PNUV8m8FQw==", "ee793742-fe9d-4f90-bf39-da1851e4e470" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b82961-40c5-4db1-982b-d048345a2fc6", "AQAAAAEAACcQAAAAEDzzlWUpnzgFrcCye77QCzlVereyPPCDFoVkrpJsXxoAtnBiiqmpw55jJMXnQPfz2w==", "9e9bdbd3-10ca-4ee7-9047-2a398cc6c399" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "830540ba-609f-4afd-a159-c23d9ffa4f15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "74b6b651-a4fb-4e6e-9ac9-5972c5d32bfc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c9fd1b0-af7f-4beb-89f8-834c6c437a39", "AQAAAAEAACcQAAAAEE/jjndJ0PxXYO9C1Nav70nA3U/2tMwByEUpWDc0voz49ET7j9djsJkvSOUAUFa+3Q==", "e105fa21-3a20-4a29-8b15-28f06824f9f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c12fed7b-542a-48aa-903e-31280141dc53", "AQAAAAEAACcQAAAAEK3UnZQ0qBHVNhDU9ZoCOdRi/ZYNuOsS6a806kSHTEiU0I16aPnXLXsRN6UcIn2pGQ==", "dda90d55-870f-4ef8-83e0-bf4d1cb8129b" });
        }
    }
}
