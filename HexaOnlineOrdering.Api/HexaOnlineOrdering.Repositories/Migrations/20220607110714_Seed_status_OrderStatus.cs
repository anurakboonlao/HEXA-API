using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_status_OrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 7, 18, 7, 12, 576, DateTimeKind.Local).AddTicks(9751),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 7, 16, 48, 21, 389, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.InsertData(
                table: "TblOrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Step1" },
                    { 9, "Step2" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(2516), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4762), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4779), new DateTime(2022, 6, 7, 18, 7, 12, 582, DateTimeKind.Local).AddTicks(4780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 7, 16, 48, 21, 389, DateTimeKind.Local).AddTicks(2205),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 7, 18, 7, 12, 576, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4184), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4187), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4188) });
        }
    }
}
