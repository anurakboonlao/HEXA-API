using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Update_TblCasePresentaionHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CasePresentationHistory_TblCase_CaseId",
                table: "CasePresentationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RejectNote_TblCase_CaseId",
                table: "RejectNote");

            migrationBuilder.DropForeignKey(
                name: "FK_RejectNote_TblUser_RejectUserId",
                table: "RejectNote");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseAttachedFile_CasePresentationHistory_CasePresentation~",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RejectNote",
                table: "RejectNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CasePresentationHistory",
                table: "CasePresentationHistory");

            migrationBuilder.RenameTable(
                name: "RejectNote",
                newName: "TblRejectNote");

            migrationBuilder.RenameTable(
                name: "CasePresentationHistory",
                newName: "TblCasePresentationHistory");

            migrationBuilder.RenameIndex(
                name: "IX_RejectNote_RejectUserId",
                table: "TblRejectNote",
                newName: "IX_TblRejectNote_RejectUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RejectNote_CaseId",
                table: "TblRejectNote",
                newName: "IX_TblRejectNote_CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_CasePresentationHistory_CaseId",
                table: "TblCasePresentationHistory",
                newName: "IX_TblCasePresentationHistory_CaseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 11, 22, 32, 341, DateTimeKind.Local).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 8, 9, 12, 5, 47, 668, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblRejectNote",
                table: "TblRejectNote",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblCasePresentationHistory",
                table: "TblCasePresentationHistory",
                column: "Id");

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
                name: "FK_TblCaseAttachedFile_TblCasePresentationHistory_CasePresentat~",
                table: "TblCaseAttachedFile",
                column: "CasePresentationHistoryId",
                principalTable: "TblCasePresentationHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCasePresentationHistory_TblCase_CaseId",
                table: "TblCasePresentationHistory",
                column: "CaseId",
                principalTable: "TblCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblRejectNote_TblCase_CaseId",
                table: "TblRejectNote",
                column: "CaseId",
                principalTable: "TblCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblRejectNote_TblUser_RejectUserId",
                table: "TblRejectNote",
                column: "RejectUserId",
                principalTable: "TblUser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseAttachedFile_TblCasePresentationHistory_CasePresentat~",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCasePresentationHistory_TblCase_CaseId",
                table: "TblCasePresentationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_TblRejectNote_TblCase_CaseId",
                table: "TblRejectNote");

            migrationBuilder.DropForeignKey(
                name: "FK_TblRejectNote_TblUser_RejectUserId",
                table: "TblRejectNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblRejectNote",
                table: "TblRejectNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblCasePresentationHistory",
                table: "TblCasePresentationHistory");

            migrationBuilder.RenameTable(
                name: "TblRejectNote",
                newName: "RejectNote");

            migrationBuilder.RenameTable(
                name: "TblCasePresentationHistory",
                newName: "CasePresentationHistory");

            migrationBuilder.RenameIndex(
                name: "IX_TblRejectNote_RejectUserId",
                table: "RejectNote",
                newName: "IX_RejectNote_RejectUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TblRejectNote_CaseId",
                table: "RejectNote",
                newName: "IX_RejectNote_CaseId");

            migrationBuilder.RenameIndex(
                name: "IX_TblCasePresentationHistory_CaseId",
                table: "CasePresentationHistory",
                newName: "IX_CasePresentationHistory_CaseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 9, 12, 5, 47, 668, DateTimeKind.Local).AddTicks(6587),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 12, 2, 11, 22, 32, 341, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RejectNote",
                table: "RejectNote",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CasePresentationHistory",
                table: "CasePresentationHistory",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 671, DateTimeKind.Local).AddTicks(8744), new DateTime(2022, 8, 9, 12, 5, 47, 671, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(98), new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 8, 9, 12, 5, 47, 672, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.AddForeignKey(
                name: "FK_CasePresentationHistory_TblCase_CaseId",
                table: "CasePresentationHistory",
                column: "CaseId",
                principalTable: "TblCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RejectNote_TblCase_CaseId",
                table: "RejectNote",
                column: "CaseId",
                principalTable: "TblCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RejectNote_TblUser_RejectUserId",
                table: "RejectNote",
                column: "RejectUserId",
                principalTable: "TblUser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseAttachedFile_CasePresentationHistory_CasePresentation~",
                table: "TblCaseAttachedFile",
                column: "CasePresentationHistoryId",
                principalTable: "CasePresentationHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
