using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_ChangeOrderName_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "order",
                table: "TblShadeSystem",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "order",
                table: "TblShade",
                newName: "Order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 16, 51, 4, 775, DateTimeKind.Local).AddTicks(3740),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 14, 53, 1, 331, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 780, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 5, 30, 16, 51, 4, 780, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2300), new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2750) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "TblShadeSystem",
                newName: "order");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "TblShade",
                newName: "order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 14, 53, 1, 331, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 16, 51, 4, 775, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 336, DateTimeKind.Local).AddTicks(9410), new DateTime(2022, 5, 30, 14, 53, 1, 336, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 5, 30, 14, 53, 1, 337, DateTimeKind.Local).AddTicks(5040) });
        }
    }
}
