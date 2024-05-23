using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_columnForShade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shade",
                table: "TblCaseProduct",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ShadeSystem",
                table: "TblCaseProduct",
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
                defaultValue: new DateTime(2021, 7, 23, 16, 50, 10, 419, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 20, 15, 34, 47, 84, DateTimeKind.Local).AddTicks(2469));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shade",
                table: "TblCaseProduct");

            migrationBuilder.DropColumn(
                name: "ShadeSystem",
                table: "TblCaseProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 20, 15, 34, 47, 84, DateTimeKind.Local).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 23, 16, 50, 10, 419, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(5970), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8012), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8022), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8025), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8026) });
        }
    }
}
