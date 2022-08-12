using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeID",
                table: "LeaveAllocations");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeID",
                table: "LeaveAllocations",
                newName: "LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeID",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeId");

            // migrationBuilder.AddColumn<int>(
               // name: "LeaveTypeID",
                // table: "LeaveAllocations",
                // type: "int",
                // nullable: false,
                // defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "LeaveTypeID",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeId",
                table: "LeaveAllocations",
                newName: "LeaveTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeID");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c93f2ada-c4a8-44b3-b2c8-08061ca0d0e9", "AQAAAAEAACcQAAAAEOWmHFVKFt9laNBAqV2XMHeCoGw30j2IFejfS/nAQbDWBkapOHxBSD7xi8riiU5TDw==", "7b3de131-2199-444e-92cc-e1966ed898a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f78979e-dc5e-40f8-9514-c1a8b21c9068", "AQAAAAEAACcQAAAAEK+ZWG88uv18PYIIo20KMBOHehMgcHRqzSUJxkbtvPkhBdzzxOifz86BcQ/5oHLM3Q==", "2ddf32a2-bc5e-4232-8d5a-23f2a5b44d32" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeID",
                table: "LeaveAllocations",
                column: "LeaveTypeID",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
