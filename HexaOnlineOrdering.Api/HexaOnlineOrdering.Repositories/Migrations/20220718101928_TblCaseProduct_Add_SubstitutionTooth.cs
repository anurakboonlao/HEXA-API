using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class TblCaseProduct_Add_SubstitutionTooth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubstitutionTooth",
                table: "TblCaseProduct",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 17, 19, 27, 19, DateTimeKind.Local).AddTicks(900),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 18, 17, 11, 16, 968, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 24, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 7, 18, 17, 19, 27, 24, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 7, 18, 17, 19, 27, 25, DateTimeKind.Local).AddTicks(4200) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubstitutionTooth",
                table: "TblCaseProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 17, 11, 16, 968, DateTimeKind.Local).AddTicks(7650),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 18, 17, 19, 27, 19, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(1330), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 7, 18, 17, 11, 16, 974, DateTimeKind.Local).AddTicks(8490) });
        }
    }
}
