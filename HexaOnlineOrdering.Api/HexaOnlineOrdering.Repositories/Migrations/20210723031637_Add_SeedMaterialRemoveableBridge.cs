using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_SeedMaterialRemoveableBridge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 23, 10, 16, 35, 685, DateTimeKind.Local).AddTicks(2278),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 20, 15, 34, 47, 84, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.InsertData(
                table: "TblMaterial",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[] { 12, null, "Flexible" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 687, DateTimeKind.Local).AddTicks(9134), new DateTime(2021, 7, 23, 10, 16, 35, 687, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(898), new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(900), new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[] { 21, 143, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 20, 15, 34, 47, 84, DateTimeKind.Local).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 23, 10, 16, 35, 685, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(5970), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8012), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8022), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8025), new DateTime(2021, 7, 20, 15, 34, 47, 87, DateTimeKind.Local).AddTicks(8026) });
        }
    }
}
