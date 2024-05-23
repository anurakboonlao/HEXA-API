using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_CatalogGroupNameGlitterPlate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 3, 15, 32, 51, 876, DateTimeKind.Local).AddTicks(1126),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 3, 15, 20, 44, 850, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.InsertData(
                table: "TblCatalogGroup",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Plate" },
                    { 2, "Glitter" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(7896), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9833), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9842), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9846), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9847) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblCatalogGroup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblCatalogGroup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 3, 15, 20, 44, 850, DateTimeKind.Local).AddTicks(726),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 3, 15, 32, 51, 876, DateTimeKind.Local).AddTicks(1126));

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
    }
}
