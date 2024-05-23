using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class IncreaseAddOnInputTextLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InputAddOn",
                table: "TblCaseProductAddOn",
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
                defaultValue: new DateTime(2021, 7, 7, 16, 45, 49, 907, DateTimeKind.Local).AddTicks(3354),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 7, 14, 11, 56, 486, DateTimeKind.Local).AddTicks(4772));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InputAddOn",
                table: "TblCaseProductAddOn",
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
                defaultValue: new DateTime(2021, 7, 7, 14, 11, 56, 486, DateTimeKind.Local).AddTicks(4772),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 7, 16, 45, 49, 907, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(5335), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7306), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7321), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7323), new DateTime(2021, 7, 7, 14, 11, 56, 489, DateTimeKind.Local).AddTicks(7324) });
        }
    }
}
