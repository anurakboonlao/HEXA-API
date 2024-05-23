using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class TblCaseProduct_Update_SubstitutionTooth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 17, 11, 16, 968, DateTimeKind.Local).AddTicks(7650),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 1, 16, 12, 7, 641, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(1330), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8490) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 16, 12, 7, 641, DateTimeKind.Local).AddTicks(1160),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 18, 17, 11, 16, 968, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 647, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 6, 1, 16, 12, 7, 647, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2110), new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2120) });
        }
    }
}
