using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class addColumnInCaseTableReferenceOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReferenceCaseId",
                table: "TblCase",
                newName: "ReferenceOrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 15, 38, 52, 344, DateTimeKind.Local).AddTicks(5462),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 13, 13, 47, 567, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.AddColumn<string>(
                name: "ReferenceOrderNumber",
                table: "TblCase",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 347, DateTimeKind.Local).AddTicks(8301), new DateTime(2021, 6, 30, 15, 38, 52, 347, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(116), new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(125), new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(146), new DateTime(2021, 6, 30, 15, 38, 52, 348, DateTimeKind.Local).AddTicks(147) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenceOrderNumber",
                table: "TblCase");

            migrationBuilder.RenameColumn(
                name: "ReferenceOrderId",
                table: "TblCase",
                newName: "ReferenceCaseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 13, 13, 47, 567, DateTimeKind.Local).AddTicks(2760),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 15, 38, 52, 344, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(3042), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7401), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7416), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7420), new DateTime(2021, 6, 30, 13, 13, 47, 571, DateTimeKind.Local).AddTicks(7421) });
        }
    }
}
