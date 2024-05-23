using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class TblFavorite_Add_SubstitutionTooth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 13, 53, 23, 818, DateTimeKind.Local).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 18, 17, 19, 27, 19, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 13, 53, 23, 823, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 7, 19, 13, 53, 23, 823, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 13, 53, 23, 824, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 7, 19, 13, 53, 23, 824, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 13, 53, 23, 824, DateTimeKind.Local).AddTicks(990), new DateTime(2022, 7, 19, 13, 53, 23, 824, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 13, 53, 23, 824, DateTimeKind.Local).AddTicks(1010), new DateTime(2022, 7, 19, 13, 53, 23, 824, DateTimeKind.Local).AddTicks(1010) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 17, 19, 27, 19, DateTimeKind.Local).AddTicks(900),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 19, 13, 53, 23, 818, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 24, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 7, 18, 17, 19, 27, 24, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4200) });
        }
    }
}
