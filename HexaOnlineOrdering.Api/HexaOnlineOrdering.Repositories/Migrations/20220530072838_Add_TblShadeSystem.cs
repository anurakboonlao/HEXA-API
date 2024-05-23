using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_TblShadeSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 14, 28, 36, 651, DateTimeKind.Local).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 26, 13, 58, 10, 18, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.CreateTable(
                name: "TblShadeSystem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    order = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblShadeSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblShadeSystem_TblProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "TblProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "TblShade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    order = table.Column<int>(type: "int", nullable: false),
                    ShadeSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblShade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblShade_TblShadeSystem_ShadeSystemId",
                        column: x => x.ShadeSystemId,
                        principalTable: "TblShadeSystem",
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
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 656, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 5, 30, 14, 28, 36, 656, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4810), new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4820), new DateTime(2022, 5, 30, 14, 28, 36, 657, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.CreateIndex(
                name: "IX_TblShade_ShadeSystemId",
                table: "TblShade",
                column: "ShadeSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_TblShadeSystem_ProductTypeId",
                table: "TblShadeSystem",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblShade");

            migrationBuilder.DropTable(
                name: "TblShadeSystem");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 26, 13, 58, 10, 18, DateTimeKind.Local).AddTicks(6960),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 14, 28, 36, 651, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 25, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 5, 26, 13, 58, 10, 25, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 5, 26, 13, 58, 10, 26, DateTimeKind.Local).AddTicks(1950) });
        }
    }
}
