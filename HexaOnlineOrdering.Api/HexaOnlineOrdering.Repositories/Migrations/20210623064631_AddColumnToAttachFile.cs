using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AddColumnToAttachFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "TblCaseAttachedFile",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 23, 13, 46, 30, 862, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(3301), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5125), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5133), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5135), new DateTime(2021, 6, 23, 13, 46, 30, 865, DateTimeKind.Local).AddTicks(5136) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropColumn(
                name: "UploadedDate",
                table: "TblCaseAttachedFile");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(2910), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(5995), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6008), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6010), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6011) });
        }
    }
}
