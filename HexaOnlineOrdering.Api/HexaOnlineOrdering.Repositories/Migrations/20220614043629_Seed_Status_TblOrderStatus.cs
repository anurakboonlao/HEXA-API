using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_Status_TblOrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 14, 11, 36, 27, 922, DateTimeKind.Local).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 14, 9, 45, 39, 956, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.InsertData(
                table: "TblOrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Step1-delivery" },
                    { 11, "Step2-delivery" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6414), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6431), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6432) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 14, 9, 45, 39, 956, DateTimeKind.Local).AddTicks(7735),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 14, 11, 36, 27, 922, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(2708), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 6, 14, 9, 45, 39, 960, DateTimeKind.Local).AddTicks(4325) });
        }
    }
}
