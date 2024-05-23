using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_User_UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblUserRole",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dentist" },
                    { 2, "Clinic" },
                    { 3, "Admin" },
                    { 4, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "UserId", "Name", "Password", "UserRoleId", "Username" },
                values: new object[,]
                {
                    { 1, "Chin Asuka", "dentist", 1, "Dentist" },
                    { 2, "Ohmkoi Hospital", "clinic", 2, "Clinic" },
                    { 3, "System Admin", "admin", 3, "Admin" },
                    { 4, "Leknoi", "staff", 4, "Staff" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblUserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblUserRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblUserRole",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblUserRole",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
