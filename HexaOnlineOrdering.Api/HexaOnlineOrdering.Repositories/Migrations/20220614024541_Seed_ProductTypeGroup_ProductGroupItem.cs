using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_ProductTypeGroup_ProductGroupItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 14, 9, 45, 39, 956, DateTimeKind.Local).AddTicks(7735),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 7, 18, 7, 12, 576, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "OrderNumber", "ProductTypeId" },
                values: new object[] { 16, false, "ICHARM", 0, 5 });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(2708), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[] { 144, 144, 16 });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[] { 145, 145, 16 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 7, 18, 7, 12, 576, DateTimeKind.Local).AddTicks(9751),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 14, 9, 45, 39, 956, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(2516), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4762), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4779), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4780) });
        }
    }
}
