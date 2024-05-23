using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblRejectNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblRejectNote_TblCase_CaseId",
                table: "TblRejectNote");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "TblRejectNote",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_TblRejectNote_CaseId",
                table: "TblRejectNote",
                newName: "IX_TblRejectNote_OrderId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 0, 37, 8, 217, DateTimeKind.Local).AddTicks(8360),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 12, 2, 11, 22, 32, 341, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(5043), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9477), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9499), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9503), new DateTime(2022, 12, 4, 0, 37, 8, 225, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.AddForeignKey(
                name: "FK_TblRejectNote_TblOrder_OrderId",
                table: "TblRejectNote",
                column: "OrderId",
                principalTable: "TblOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblRejectNote_TblOrder_OrderId",
                table: "TblRejectNote");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "TblRejectNote",
                newName: "CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_TblRejectNote_OrderId",
                table: "TblRejectNote",
                newName: "IX_TblRejectNote_CaseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 11, 22, 32, 341, DateTimeKind.Local).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 12, 4, 0, 37, 8, 217, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 22, 32, 348, DateTimeKind.Local).AddTicks(3369), new DateTime(2022, 12, 2, 11, 22, 32, 348, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 22, 32, 348, DateTimeKind.Local).AddTicks(9975), new DateTime(2022, 12, 2, 11, 22, 32, 348, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 22, 32, 348, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 12, 2, 11, 22, 32, 348, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 22, 32, 349, DateTimeKind.Local).AddTicks(1), new DateTime(2022, 12, 2, 11, 22, 32, 349, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.AddForeignKey(
                name: "FK_TblRejectNote_TblCase_CaseId",
                table: "TblRejectNote",
                column: "CaseId",
                principalTable: "TblCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
