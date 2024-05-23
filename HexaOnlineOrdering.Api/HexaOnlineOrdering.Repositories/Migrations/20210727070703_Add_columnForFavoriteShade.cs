using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_columnForFavoriteShade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shade",
                table: "TblFavorite",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ShadeSystem",
                table: "TblFavorite",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 7, 1, 898, DateTimeKind.Local).AddTicks(9483),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 23, 16, 50, 10, 419, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(4204), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7182), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7213), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7216), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7217) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shade",
                table: "TblFavorite");

            migrationBuilder.DropColumn(
                name: "ShadeSystem",
                table: "TblFavorite");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 23, 16, 50, 10, 419, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 7, 1, 898, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(5647), new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(7484), new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(7491), new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(7493), new DateTime(2021, 7, 23, 16, 50, 10, 422, DateTimeKind.Local).AddTicks(7494) });
        }
    }
}
