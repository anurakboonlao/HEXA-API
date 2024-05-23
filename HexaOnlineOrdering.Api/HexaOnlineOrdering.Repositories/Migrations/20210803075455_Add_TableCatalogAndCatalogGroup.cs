using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_TableCatalogAndCatalogGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 3, 14, 54, 53, 896, DateTimeKind.Local).AddTicks(3828),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 7, 1, 898, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.CreateTable(
                name: "TblCatalogGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatalogGroup", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblCatalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoPath = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CatalogGroupId = table.Column<int>(type: "int", nullable: false),
                    Disabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValueSql: "'0'"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCatalog_TblCatalogGroup_CatalogGroupId",
                        column: x => x.CatalogGroupId,
                        principalTable: "TblCatalogGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(2200), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4359), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4367), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4369), new DateTime(2021, 8, 3, 14, 54, 53, 902, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.CreateIndex(
                name: "IX_TblCatalog_CatalogGroupId",
                table: "TblCatalog",
                column: "CatalogGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblCatalog");

            migrationBuilder.DropTable(
                name: "TblCatalogGroup");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 7, 1, 898, DateTimeKind.Local).AddTicks(9483),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 3, 14, 54, 53, 896, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(4204), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7182), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7213), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7216), new DateTime(2021, 7, 27, 14, 7, 1, 903, DateTimeKind.Local).AddTicks(7217) });
        }
    }
}
