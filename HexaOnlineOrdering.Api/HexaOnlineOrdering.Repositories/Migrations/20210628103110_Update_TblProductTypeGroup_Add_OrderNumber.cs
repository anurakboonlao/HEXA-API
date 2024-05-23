using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblProductTypeGroup_Add_OrderNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "TblProductTypeGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 17, 31, 9, 471, DateTimeKind.Local).AddTicks(4231),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 17, 8, 32, 828, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(4810), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7585), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7598), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7601), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7602) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "TblProductTypeGroup");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 17, 8, 32, 828, DateTimeKind.Local).AddTicks(2977),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 17, 31, 9, 471, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 831, DateTimeKind.Local).AddTicks(8097), new DateTime(2021, 6, 28, 17, 8, 32, 831, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1614), new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1630), new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1633), new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1634) });
        }
    }
}
