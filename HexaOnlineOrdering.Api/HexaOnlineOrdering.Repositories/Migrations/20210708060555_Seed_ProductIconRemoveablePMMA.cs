using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_ProductIconRemoveablePMMA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 8, 13, 5, 54, 191, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 1, 15, 46, 34, 861, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/procelain-margin.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 126,
                column: "LogoPath",
                value: "/ProductIcon/Removable/Products/pmma.jpg");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(2890), new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(6037), new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(6047), new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(6050), new DateTime(2021, 7, 8, 13, 5, 54, 194, DateTimeKind.Local).AddTicks(6051) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 15, 46, 34, 861, DateTimeKind.Local).AddTicks(7527),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 8, 13, 5, 54, 191, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 126,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(1338), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4564), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4578), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4581), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4582) });
        }
    }
}
