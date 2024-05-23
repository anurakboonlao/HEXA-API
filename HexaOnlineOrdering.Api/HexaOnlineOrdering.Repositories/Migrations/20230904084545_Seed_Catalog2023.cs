using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_Catalog2023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 4, 15, 45, 44, 150, DateTimeKind.Local).AddTicks(6829),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 12, 4, 0, 37, 8, 217, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.InsertData(
                table: "TblCatalog",
                columns: new[] { "Id", "CatalogGroupId", "LogoPath", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 194, 1, "/Catalog/HC63.jpg", "HC 63", 96 },
                    { 195, 1, "/Catalog/HC64.jpg", "HC 64", 97 },
                    { 196, 1, "/Catalog/HC65.jpg", "HC 65", 98 },
                    { 197, 1, "/Catalog/HC66.jpg", "HC 66", 99 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(7117), new DateTime(2023, 9, 4, 15, 45, 44, 153, DateTimeKind.Local).AddTicks(7118) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 0, 37, 8, 217, DateTimeKind.Local).AddTicks(8360),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 9, 4, 15, 45, 44, 150, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(5043), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9477), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9499), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9503), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9505) });
        }
    }
}
