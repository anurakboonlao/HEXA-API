using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AddMaterialInlayOnlay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 14, 56, 15, 129, DateTimeKind.Local).AddTicks(2244),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 11, 3, 14, 57, 44, 457, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.InsertData(
                table: "TblMaterial",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 13, "/ProductIcon/CrownAndBridge/InlayOnlay/eMax.jpg", "E-Max" },
                    { 14, "/ProductIcon/Zircon/zircon.jpeg", "Zircon" }
                });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[,]
                {
                    { 22, 16, 1 },
                    { 23, 16, 2 },
                    { 24, 16, 3 },
                    { 25, 16, 4 },
                    { 26, 16, 5 },
                    { 27, 16, 6 },
                    { 28, 16, 7 },
                    { 29, 16, 10 },
                    { 30, 16, 11 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(7562), new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(9676), new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(9685), new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(9687), new DateTime(2021, 11, 4, 14, 56, 15, 132, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[] { 31, 16, 13 });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[] { 32, 16, 14 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 3, 14, 57, 44, 457, DateTimeKind.Local).AddTicks(3921),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 11, 4, 14, 56, 15, 129, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(378), new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(2330), new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(2339), new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(2341), new DateTime(2021, 11, 3, 14, 57, 44, 461, DateTimeKind.Local).AddTicks(2342) });
        }
    }
}
