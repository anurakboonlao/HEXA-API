using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblFavorite_Add_ShadeSystemId_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 14, 53, 1, 331, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 14, 42, 27, 345, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 336, DateTimeKind.Local).AddTicks(9410), new DateTime(2022, 5, 30, 14, 53, 1, 336, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5040) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 14, 42, 27, 345, DateTimeKind.Local).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 14, 53, 1, 331, DateTimeKind.Local).AddTicks(4550));

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
    }
}
