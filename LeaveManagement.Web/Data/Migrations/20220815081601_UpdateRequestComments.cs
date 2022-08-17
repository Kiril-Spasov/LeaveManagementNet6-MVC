using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c273e27-4c64-4c1e-bb14-35120c03b52b",
                column: "ConcurrencyStamp",
                value: "3e6db349-d41c-4607-b8f1-776922e8323e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c274e28-4c64-4c1e-bb14-35120c03b52c",
                column: "ConcurrencyStamp",
                value: "4148007a-af0b-453c-ae8a-d11c30cef4ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c272e26-4c64-4c1e-bb14-35120c03b52a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cc3b95b-caf9-423f-9e82-212701ad5522", "AQAAAAEAACcQAAAAENMWDLtJUyOxm3NjhM8f/1RJ1uOkfO+JnlPtOgN6BgEfNT983qiIRPcLcQury35FuA==", "75428a05-602c-488c-aa08-4080c6b061a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25eeb5c8-c443-4ad7-8732-f2786a730f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a4e99cf-2ce1-4213-bfe2-581d070fe6ca", "AQAAAAEAACcQAAAAEHA1wdM60khaZx6zUPHzlb1FURguk2qfovTZ/Z2DzL6XS1HNxxxAtOHySfd5Bnwy3A==", "fcb9dcba-4ae8-4529-b733-2d5a66b8de8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
