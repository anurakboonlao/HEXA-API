using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_disable_old_Catalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 25, 22, 52, 50, 209, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 8, 25, 22, 27, 52, 573, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(4723), new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(6218), new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(6225), new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 8, 25, 22, 52, 50, 212, DateTimeKind.Local).AddTicks(6228) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 25, 22, 27, 52, 573, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 8, 25, 22, 52, 50, 209, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5288), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5295), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5298), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5299) });
        }
    }
}
