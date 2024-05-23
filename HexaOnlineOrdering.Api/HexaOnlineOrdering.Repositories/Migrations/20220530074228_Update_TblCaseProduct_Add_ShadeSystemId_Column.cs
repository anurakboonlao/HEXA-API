using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblCaseProduct_Add_ShadeSystemId_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShadeId",
                table: "TblFavorite",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShadeSystemId",
                table: "TblFavorite",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShadeId",
                table: "TblCaseProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShadeSystemId",
                table: "TblCaseProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 14, 42, 27, 345, DateTimeKind.Local).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 14, 28, 36, 651, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 42, 27, 351, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 5, 30, 14, 42, 27, 351, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 42, 27, 352, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 5, 30, 14, 42, 27, 352, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 42, 27, 352, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 5, 30, 14, 42, 27, 352, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 42, 27, 352, DateTimeKind.Local).AddTicks(570), new DateTime(2022, 5, 30, 14, 42, 27, 352, DateTimeKind.Local).AddTicks(570) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShadeId",
                table: "TblFavorite");

            migrationBuilder.DropColumn(
                name: "ShadeSystemId",
                table: "TblFavorite");

            migrationBuilder.DropColumn(
                name: "ShadeId",
                table: "TblCaseProduct");

            migrationBuilder.DropColumn(
                name: "ShadeSystemId",
                table: "TblCaseProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 14, 28, 36, 651, DateTimeKind.Local).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 14, 42, 27, 345, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 656, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 5, 30, 14, 28, 36, 656, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4810), new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4820), new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4820) });
        }
    }
}
