using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_IconRemovable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 16, 40, 29, 351, DateTimeKind.Local).AddTicks(6105),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 15, 12, 7, 21, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/full_denture.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/partial_denture_framework.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/Temporary%20patial%20plate.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/bite_block.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 5,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/chrome_cobalt.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 6,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/flexible_denture.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/Special%20tray.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 8,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/peek.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 9,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/peek_for_rpd-aceltal_%20plate.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 10,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/rb_all_acetal.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 11,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/peek_for_rpd-aceltal_%20plate.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 12,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/rb_all_acetal.jpg");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(4760), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7377), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7385), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7388), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7389) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 15, 12, 7, 21, DateTimeKind.Local).AddTicks(2682),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 16, 40, 29, 351, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 5,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 6,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 8,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 9,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 10,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 11,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 12,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(1043), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3758), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3767), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3770), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3771) });
        }
    }
}
