using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class TblFavorite_Add_SubstitutionTooth_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubstitutionTooth",
                table: "TblFavorite",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 14, 11, 35, 154, DateTimeKind.Local).AddTicks(5420),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 19, 13, 53, 23, 818, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7770) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubstitutionTooth",
                table: "TblFavorite");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 13, 53, 23, 818, DateTimeKind.Local).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 19, 14, 11, 35, 154, DateTimeKind.Local).AddTicks(5420));

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
    }
}
