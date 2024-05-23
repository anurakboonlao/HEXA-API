using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_User_Add_Columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "TblUser",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "TblUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "TblUser",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "TblUser",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Active", "CreateAt", "LastUpdate" },
                values: new object[] { true, new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(2350), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Active", "CreateAt", "LastUpdate" },
                values: new object[] { true, new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4120), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Active", "CreateAt", "LastUpdate" },
                values: new object[] { true, new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Active", "CreateAt", "LastUpdate" },
                values: new object[] { true, new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4140) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "TblUser");
        }
    }
}
