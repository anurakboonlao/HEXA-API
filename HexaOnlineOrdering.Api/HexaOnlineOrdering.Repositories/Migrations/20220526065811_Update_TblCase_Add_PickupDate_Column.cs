using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblCase_Add_PickupDate_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 26, 13, 58, 10, 18, DateTimeKind.Local).AddTicks(6960),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 11, 4, 15, 10, 19, 672, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.AddColumn<DateTime>(
                name: "PickupDate",
                table: "TblCase",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 25, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 5, 26, 13, 58, 10, 25, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1950) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickupDate",
                table: "TblCase");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 15, 10, 19, 672, DateTimeKind.Local).AddTicks(5336),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 26, 13, 58, 10, 18, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(3617), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6143), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6160), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6164) });
        }
    }
}
