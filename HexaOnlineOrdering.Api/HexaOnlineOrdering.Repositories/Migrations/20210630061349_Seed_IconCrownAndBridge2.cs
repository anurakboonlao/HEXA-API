using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_IconCrownAndBridge2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 13, 13, 47, 567, DateTimeKind.Local).AddTicks(2760),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 12, 46, 59, 811, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 132,
                column: "LogoPath",
                value: "/ProductIcon/Zircon/zircon-crown.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 133,
                column: "LogoPath",
                value: "/ProductIcon/Zircon/full-zircom.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 134,
                column: "LogoPath",
                value: "/ProductIcon/Zircon/full-zircom.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 135,
                column: "LogoPath",
                value: "/ProductIcon/Zircon/full-zircom.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 136,
                column: "LogoPath",
                value: "/ProductIcon/Implants/stend-for-implant.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 137,
                column: "LogoPath",
                value: "/ProductIcon/Implants/Premilled-titanium.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 138,
                column: "LogoPath",
                value: "/ProductIcon/Implants/ful-milled-titanium.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 139,
                column: "LogoPath",
                value: "/ProductIcon/Implants/milled-titanium-bar.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 140,
                column: "LogoPath",
                value: "/ProductIcon/Implants/milled-cocr-implant-bridge.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 141,
                column: "LogoPath",
                value: "/ProductIcon/Implants/peek-for-crown-per-unit.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 142,
                column: "LogoPath",
                value: "/ProductIcon/IndividualAbutments/zircom-abument.jpg");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(3042), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7401), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7416), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7420), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7421) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 12, 46, 59, 811, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 13, 13, 47, 567, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 132,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 133,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 134,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 135,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 136,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 137,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 138,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 139,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 140,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 141,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 142,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 814, DateTimeKind.Local).AddTicks(7284), new DateTime(2021, 6, 30, 12, 46, 59, 814, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(326), new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(337), new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(340), new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(341) });
        }
    }
}
