using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AddCasePresentationHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 1, 51, 14, 304, DateTimeKind.Local).AddTicks(7184),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 7, 19, 14, 11, 35, 154, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.AddColumn<int>(
                name: "CasePresentationHistoryId",
                table: "TblCaseAttachedFile",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aligners",
                table: "TblCase",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CasePresentationHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RequestEditDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasePresentationHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CasePresentationHistory_TblCase_CaseId",
                        column: x => x.CaseId,
                        principalTable: "TblCase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "RejectNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RejectDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    RejectUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejectNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RejectNote_TblCase_CaseId",
                        column: x => x.CaseId,
                        principalTable: "TblCase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RejectNote_TblUser_RejectUserId",
                        column: x => x.RejectUserId,
                        principalTable: "TblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(1348), new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(8022), new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(8082), new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(8086), new DateTime(2022, 12, 2, 1, 51, 14, 316, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseAttachedFile_CasePresentationHistoryId",
                table: "TblCaseAttachedFile",
                column: "CasePresentationHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CasePresentationHistory_CaseId",
                table: "CasePresentationHistory",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_RejectNote_CaseId",
                table: "RejectNote",
                column: "CaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RejectNote_RejectUserId",
                table: "RejectNote",
                column: "RejectUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseAttachedFile_CasePresentationHistory_CasePresentation~",
                table: "TblCaseAttachedFile",
                column: "CasePresentationHistoryId",
                principalTable: "CasePresentationHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseAttachedFile_CasePresentationHistory_CasePresentation~",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropTable(
                name: "CasePresentationHistory");

            migrationBuilder.DropTable(
                name: "RejectNote");

            migrationBuilder.DropIndex(
                name: "IX_TblCaseAttachedFile_CasePresentationHistoryId",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropColumn(
                name: "CasePresentationHistoryId",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropColumn(
                name: "Aligners",
                table: "TblCase");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 14, 11, 35, 154, DateTimeKind.Local).AddTicks(5420),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 12, 2, 1, 51, 14, 304, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 7, 19, 14, 11, 35, 160, DateTimeKind.Local).AddTicks(7770) });
        }
    }
}
