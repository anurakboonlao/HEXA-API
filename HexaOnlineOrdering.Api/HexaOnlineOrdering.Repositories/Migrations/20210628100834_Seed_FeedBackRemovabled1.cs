using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_FeedBackRemovabled1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 17, 8, 32, 828, DateTimeKind.Local).AddTicks(2977),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 16, 47, 8, 705, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "All Acetal Plate");

            migrationBuilder.InsertData(
                table: "TblMasterProduct",
                columns: new[] { "Id", "Code", "ColorCode", "ExpectedProductDay", "LogoPath", "Name", "ProductTypeId" },
                values: new object[] { 143, null, "", 3, "", "Removable Bridge", 2 });

            migrationBuilder.InsertData(
                table: "TblMaterial",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Metal" },
                    { 9, "Acrylic" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 831, DateTimeKind.Local).AddTicks(8097), new DateTime(2021, 6, 28, 17, 8, 32, 831, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1614), new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1630), new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1633), new DateTime(2021, 6, 28, 17, 8, 32, 832, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[] { 143, 143, 2 });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[] { 15, 143, 8 });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[] { 16, 143, 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 16, 47, 8, 705, DateTimeKind.Local).AddTicks(8254),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 17, 8, 32, 828, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Acetal Plate");

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
        }
    }
}
