using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddOnStickerInOrthopedicAndOrthodonticFixDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 7, 14, 11, 56, 486, DateTimeKind.Local).AddTicks(4772),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 6, 18, 14, 19, 508, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45,
                column: "DisplayName",
                value: "Labial Plate");

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "DisplayName",
                value: "Buccal Plate");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(5335), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7306), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7321), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7323), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7324) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 18, 14, 19, 508, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 7, 14, 11, 56, 486, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45,
                column: "DisplayName",
                value: "Acrylic Plate");

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "DisplayName",
                value: "Acrylic Plate");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(1970), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3771), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3781), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3783), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3784) });
        }
    }
}
