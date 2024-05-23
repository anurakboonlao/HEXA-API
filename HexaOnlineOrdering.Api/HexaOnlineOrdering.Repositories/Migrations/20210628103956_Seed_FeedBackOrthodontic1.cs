using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_FeedBackOrthodontic1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 17, 39, 55, 426, DateTimeKind.Local).AddTicks(847),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 17, 31, 9, 471, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(5647), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8437), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8448), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8451), new DateTime(2021, 6, 28, 17, 39, 55, 429, DateTimeKind.Local).AddTicks(8452) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 28, 17, 31, 9, 471, DateTimeKind.Local).AddTicks(4231),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 28, 17, 39, 55, 426, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(4810), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7585), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7598), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7601), new DateTime(2021, 6, 28, 17, 31, 9, 475, DateTimeKind.Local).AddTicks(7602) });
        }
    }
}
