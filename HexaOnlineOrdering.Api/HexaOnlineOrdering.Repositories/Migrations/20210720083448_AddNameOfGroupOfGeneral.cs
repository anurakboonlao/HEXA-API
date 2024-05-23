using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AddNameOfGroupOfGeneral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 20, 15, 34, 47, 84, DateTimeKind.Local).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 8, 13, 5, 54, 191, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayAsGroup", "Name" },
                values: new object[] { true, "General" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 8, 13, 5, 54, 191, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 20, 15, 34, 47, 84, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayAsGroup", "Name" },
                values: new object[] { false, "Crown & Bridge" });

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
    }
}
