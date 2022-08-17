using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "f05d0123-99fa-4a56-b502-e2860a063c63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "71693f74-fe32-4722-a1df-a45d058b8cd2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f5503d-94d1-48b4-8e2c-284f761a5ca3", "AQAAAAEAACcQAAAAEPtRTKLiSRS4YG/74VfZpGNNerCiafltvRuUdCIs+WjS1qrfLnwkmiwcTKH38T2kBw==", "29654ed9-ada0-4389-bc7e-42a239b48f13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9591ca67-aae5-456a-ad85-da1b770ae090", "AQAAAAEAACcQAAAAEAjC6kagr3M79smdG8muh6yW3HjadJlBBwbTZiNkNhQrVwd23gTTpUxQTnEMlip6lg==", "35e80cb7-d245-40de-87c7-628ec7b9dbaa" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
