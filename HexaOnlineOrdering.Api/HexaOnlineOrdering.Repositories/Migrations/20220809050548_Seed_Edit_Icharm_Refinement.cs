using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_Edit_Icharm_Refinement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 12, 5, 47, 668, DateTimeKind.Local).AddTicks(6587),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 19, 14, 11, 35, 154, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Refinement");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 671, DateTimeKind.Local).AddTicks(8744), new DateTime(2022, 8, 9, 12, 5, 47, 671, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(98), new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(101) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 14, 11, 35, 154, DateTimeKind.Local).AddTicks(5420),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 8, 9, 12, 5, 47, 668, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Remake");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7770) });
        }
    }
}
