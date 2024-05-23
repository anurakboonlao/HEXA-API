using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblDesign_Add_LogoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "TblMaterial",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "TblDesign",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 9, 57, 21, 387, DateTimeKind.Local).AddTicks(6917),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 17, 39, 55, 426, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(4135), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7706), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7716), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7720), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7722) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "TblMaterial");

            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "TblDesign");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 17, 39, 55, 426, DateTimeKind.Local).AddTicks(847),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 9, 57, 21, 387, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(5647), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8437), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8448), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8451), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8452) });
        }
    }
}
