using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblCaseProduct_AddShadeSystemIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 10, 26, 5, 616, DateTimeKind.Local).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 31, 17, 13, 14, 818, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.AddColumn<int>(
                name: "ShadeId",
                table: "TblCase",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShadeSystemId",
                table: "TblCase",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 26, 5, 621, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 6, 1, 10, 26, 5, 621, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 26, 5, 622, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 6, 1, 10, 26, 5, 622, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 26, 5, 622, DateTimeKind.Local).AddTicks(4900), new DateTime(2022, 6, 1, 10, 26, 5, 622, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 26, 5, 622, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 6, 1, 10, 26, 5, 622, DateTimeKind.Local).AddTicks(4910) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShadeId",
                table: "TblCase");

            migrationBuilder.DropColumn(
                name: "ShadeSystemId",
                table: "TblCase");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 31, 17, 13, 14, 818, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 1, 10, 26, 5, 616, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 823, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 5, 31, 17, 13, 14, 823, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(5000) });
        }
    }
}
