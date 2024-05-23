using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_statusCancel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 15, 46, 34, 861, DateTimeKind.Local).AddTicks(7527),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 15, 38, 52, 344, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.InsertData(
                table: "TblOrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Canceled" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(1338), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4564), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4578), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4581), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4582) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 15, 38, 52, 344, DateTimeKind.Local).AddTicks(5462),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 1, 15, 46, 34, 861, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 347, DateTimeKind.Local).AddTicks(8301), new DateTime(2021, 6, 30, 15, 38, 52, 347, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(116), new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(125), new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(146), new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(147) });
        }
    }
}
