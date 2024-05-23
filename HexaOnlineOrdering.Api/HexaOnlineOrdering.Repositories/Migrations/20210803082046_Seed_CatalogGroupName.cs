using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_CatalogGroupName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 3, 15, 20, 44, 850, DateTimeKind.Local).AddTicks(726),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 3, 14, 54, 53, 896, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(6462), new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(8368), new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(8376), new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(8379), new DateTime(2021, 8, 3, 15, 20, 44, 855, DateTimeKind.Local).AddTicks(8380) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 3, 14, 54, 53, 896, DateTimeKind.Local).AddTicks(3828),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 3, 15, 20, 44, 850, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(2200), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4359), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4367), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4369), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4370) });
        }
    }
}
