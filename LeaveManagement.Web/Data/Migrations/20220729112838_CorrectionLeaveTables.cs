using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class CorrectionLeaveTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeID",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_LeaveTypeID",
                table: "LeaveAllocations");

            // migrationBuilder.DropColumn(
                // name: "LeaveTypeID",
                // table: "LeaveAllocations");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeId",
                table: "LeaveAllocations",
                newName: "LeaveTypeID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c273e27-4c64-4c1e-bb14-35120c03b52b", "934f5eb5-e0de-4322-a71b-2c7f72b279dd", "Administrator", "ADMINISTRATOR" },
                    { "0c274e28-4c64-4c1e-bb14-35120c03b52c", "2c50791a-dc14-46de-bf7b-e354bbfbf227", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c272e26-4c64-4c1e-bb14-35120c03b52a", 0, "e3c7612d-c1fe-4b48-bb75-248dc8fb405e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAECFrXdnUrLxFaPiAbuFLR7bfekI7suEjzMSREex6D+Ec+hBVPjCiqRjtOh31PLDdNQ==", null, false, "92f4f9d3-b61b-4d1b-b56d-f8f18b9b3aa1", null, false, null },
                    { "25eeb5c8-c443-4ad7-8732-f2786a730f01", 0, "50f0b224-e32e-48c4-923e-14b5999cb8fe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEGaKuP9pHR4pesQSlMKTilQMWWWJ+J79+rqpurQ9P5NtRFaoGC8YQHSIgAVK6bGnBQ==", null, false, "714c6ee1-e813-4e99-b95f-53c6670113a8", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c273e27-4c64-4c1e-bb14-35120c03b52b", "0c272e26-4c64-4c1e-bb14-35120c03b52a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c274e28-4c64-4c1e-bb14-35120c03b52c", "25eeb5c8-c443-4ad7-8732-f2786a730f01" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeID",
                table: "LeaveAllocations",
                column: "LeaveTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeID",
                table: "LeaveAllocations",
                column: "LeaveTypeID",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeID",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_LeaveTypeID",
                table: "LeaveAllocations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c273e27-4c64-4c1e-bb14-35120c03b52b", "0c272e26-4c64-4c1e-bb14-35120c03b52a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c274e28-4c64-4c1e-bb14-35120c03b52c", "25eeb5c8-c443-4ad7-8732-f2786a730f01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeID",
                table: "LeaveAllocations",
                newName: "LeaveTypeId");

            migrationBuilder.AddColumn<int>(
                name: "LeaveTypeID",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeID",
                table: "LeaveAllocations",
                column: "LeaveTypeID");

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
