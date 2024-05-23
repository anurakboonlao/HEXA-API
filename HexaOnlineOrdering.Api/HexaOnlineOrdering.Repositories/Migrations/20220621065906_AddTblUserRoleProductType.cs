using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AddTblUserRoleProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 21, 13, 59, 3, 199, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 14, 11, 36, 27, 922, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.CreateTable(
                name: "TblProductTypeTblUserRole",
                columns: table => new
                {
                    ProductTypeIdId = table.Column<int>(type: "int", nullable: false),
                    UserRoleIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProductTypeTblUserRole", x => new { x.ProductTypeIdId, x.UserRoleIdId });
                    table.ForeignKey(
                        name: "FK_TblProductTypeTblUserRole_TblProductType_ProductTypeIdId",
                        column: x => x.ProductTypeIdId,
                        principalTable: "TblProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblProductTypeTblUserRole_TblUserRole_UserRoleIdId",
                        column: x => x.UserRoleIdId,
                        principalTable: "TblUserRole",
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
                values: new object[] { new DateTime(2022, 6, 21, 13, 59, 3, 205, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 6, 21, 13, 59, 3, 205, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 21, 13, 59, 3, 206, DateTimeKind.Local).AddTicks(1110), new DateTime(2022, 6, 21, 13, 59, 3, 206, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 21, 13, 59, 3, 206, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 6, 21, 13, 59, 3, 206, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 21, 13, 59, 3, 206, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 6, 21, 13, 59, 3, 206, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.CreateIndex(
                name: "IX_TblProductTypeTblUserRole_UserRoleIdId",
                table: "TblProductTypeTblUserRole",
                column: "UserRoleIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblProductTypeTblUserRole");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 14, 11, 36, 27, 922, DateTimeKind.Local).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 21, 13, 59, 3, 199, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6414), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6431), new DateTime(2022, 6, 14, 11, 36, 27, 928, DateTimeKind.Local).AddTicks(6432) });
        }
    }
}
