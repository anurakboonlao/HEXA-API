using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_FeedBackCrownAndBridge1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 16, 47, 8, 705, DateTimeKind.Local).AddTicks(8254),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 23, 13, 46, 30, 862, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.InsertData(
                table: "TblMasterProduct",
                columns: new[] { "Id", "Code", "ColorCode", "ExpectedProductDay", "LogoPath", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 126, null, "", 3, "", "PMMA (CAD/CAM)", 1 },
                    { 142, null, "", 3, "", "Zircon Abutment", 1 },
                    { 141, null, "", 3, "", "Peek for crown per unit", 1 },
                    { 140, null, "", 3, "", "Milled CoCr Implant Bridge", 1 },
                    { 138, null, "", 3, "", "Full-milled Titanium", 1 },
                    { 137, null, "", 3, "", "Pre-milled Titanium", 1 },
                    { 136, null, "", 3, "", "Stent for Implant", 1 },
                    { 135, null, "", 3, "", "Full Zircon Multilayer (High translucent)", 1 },
                    { 139, null, "", 3, "", "Milled Titanium Bar ( all on 4 )", 1 },
                    { 133, null, "", 3, "", "Full Zircon Crown & Bridge", 1 },
                    { 132, null, "", 3, "", "Zircon Crown (with Porcelain Layer)", 1 },
                    { 131, null, "", 3, "", "Lisi Press", 1 },
                    { 130, null, "", 3, "", "Tetric Cad", 1 },
                    { 129, null, "", 3, "", "Empress Cad", 1 },
                    { 128, null, "", 3, "", "E max Cad", 1 },
                    { 127, null, "", 3, "", "E max", 1 },
                    { 134, null, "", 3, "", "Full Zircon Multilayer (High Strength)", 1 }
                });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "High White Gold (Au 76.80%)");

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Other");

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 15, true, "Individual Abutments", 1 },
                    { 12, true, "All Ceramics", 1 },
                    { 13, true, "Zircon Products", 1 },
                    { 14, true, "Implants", 1 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(2329), new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(5213), new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(5223), new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(5226), new DateTime(2021, 6, 28, 16, 47, 8, 709, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[,]
                {
                    { 126, 126, 1 },
                    { 140, 140, 14 },
                    { 139, 139, 14 },
                    { 138, 138, 14 },
                    { 137, 137, 14 },
                    { 136, 136, 14 },
                    { 135, 135, 13 },
                    { 141, 141, 14 },
                    { 134, 134, 13 },
                    { 132, 132, 13 },
                    { 131, 131, 12 },
                    { 130, 130, 12 },
                    { 129, 129, 12 },
                    { 128, 128, 12 },
                    { 127, 127, 12 },
                    { 133, 133, 13 },
                    { 142, 142, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 13, 46, 30, 862, DateTimeKind.Local).AddTicks(7241),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 16, 47, 8, 705, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "High White Gold");

            migrationBuilder.InsertData(
                table: "TblMaterial",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "E max" },
                    { 9, "E max Cad" },
                    { 10, "Empress Cad" },
                    { 11, "Tetric Cad" },
                    { 12, "Lisi Press" }
                });

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Orther");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(3301), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5125), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5133), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5135), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[,]
                {
                    { 15, 16, 8 },
                    { 16, 16, 9 },
                    { 17, 16, 10 },
                    { 18, 16, 11 },
                    { 19, 16, 12 }
                });
        }
    }
}
