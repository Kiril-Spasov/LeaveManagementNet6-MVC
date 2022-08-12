using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class CorrectionLeaveTypeId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LeaveTypeID",
                table: "LeaveAllocations",
                newName: "LeaveTypeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "47056321-d6b9-4014-ad61-366ff64bde05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "57e4cd00-c36a-449a-bd25-23cf66fc29a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f25bcc8-1ef0-472d-92d5-666f497051d6", "AQAAAAEAACcQAAAAEBolNrE93Vqpe/pgiGRrawHFzeTYtFFT3WLAznRY8nzJO2P89xjcBs3m6TO74PY3Fg==", "665a5f0c-981a-4e34-8178-286b5594b598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acad144c-a338-4b96-b85f-fbbeed225a25", "AQAAAAEAACcQAAAAENSk/Y212OWbNiV+0qW8vXIlnF4zWazLeUB2pfYvBXYvszw7B4/3T4Ke/NFGmBlPDw==", "dac40cb6-44cb-4fae-b77b-4f6697a12d60" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeaveTypeID",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
