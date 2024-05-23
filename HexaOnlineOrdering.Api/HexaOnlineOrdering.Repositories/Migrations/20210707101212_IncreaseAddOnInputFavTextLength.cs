using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class IncreaseAddOnInputFavTextLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InputAddOn",
                table: "TblFavoriteAddOn",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 7, 17, 12, 11, 674, DateTimeKind.Local).AddTicks(2535),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 7, 16, 45, 49, 907, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(5945), new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(7731), new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(7739), new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(7741), new DateTime(2021, 7, 7, 17, 12, 11, 677, DateTimeKind.Local).AddTicks(7742) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InputAddOn",
                table: "TblFavoriteAddOn",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 7, 16, 45, 49, 907, DateTimeKind.Local).AddTicks(3354),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 7, 17, 12, 11, 674, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 16, 45, 49, 910, DateTimeKind.Local).AddTicks(9927), new DateTime(2021, 7, 7, 16, 45, 49, 910, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 16, 45, 49, 911, DateTimeKind.Local).AddTicks(2200), new DateTime(2021, 7, 7, 16, 45, 49, 911, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 16, 45, 49, 911, DateTimeKind.Local).AddTicks(2216), new DateTime(2021, 7, 7, 16, 45, 49, 911, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 16, 45, 49, 911, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 7, 7, 16, 45, 49, 911, DateTimeKind.Local).AddTicks(2219) });
        }
    }
}
