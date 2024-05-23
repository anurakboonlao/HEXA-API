using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AddMateirialVaneer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 15, 10, 19, 672, DateTimeKind.Local).AddTicks(5336),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 11, 4, 14, 56, 15, 129, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.InsertData(
                table: "TblMaterial",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 15, "/ProductIcon/CrownAndBridge/InlayOnlay/eMaxCad.jpg", "E max Cad" },
                    { 16, "/ProductIcon/CrownAndBridge/InlayOnlay/EmpressCad.jpg", "Empress Cad" },
                    { 17, "/ProductIcon/CrownAndBridge/InlayOnlay/TetricCad.jpg", "Tetric Cad" },
                    { 18, "/ProductIcon/CrownAndBridge/InlayOnlay/LisiPress.jpg", "Lisi Press" },
                    { 19, "/ProductIcon/Zircon/zircon.jpeg", "Zircon With Pocelainer Layer" },
                    { 20, "/ProductIcon/Zircon/zircon.jpeg", "Full Zircon Multilayer ( High Translucent )" },
                    { 21, "/ProductIcon/Amber/amber.png", "Amber" }
                });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[] { 33, 17, 13 });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(3617), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6143), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6160), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[,]
                {
                    { 34, 17, 15 },
                    { 35, 17, 16 },
                    { 36, 17, 17 },
                    { 37, 17, 18 },
                    { 38, 17, 19 },
                    { 39, 17, 20 },
                    { 40, 17, 21 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 14, 56, 15, 129, DateTimeKind.Local).AddTicks(2244),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 11, 4, 15, 10, 19, 672, DateTimeKind.Local).AddTicks(5336));

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
        }
    }
}
