using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class AlterCaseProductForMultiProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCase_TblMethod_MethodId",
                table: "TblCase");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCase_TblProductType_ProductTypeId",
                table: "TblCase");

            migrationBuilder.DropIndex(
                name: "IX_TblCase_MethodId",
                table: "TblCase");

            migrationBuilder.DropIndex(
                name: "IX_TblCase_ProductTypeId",
                table: "TblCase");

            migrationBuilder.DropColumn(
                name: "MethodId",
                table: "TblCase");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "TblCase");

            migrationBuilder.AddColumn<int>(
                name: "MethodId",
                table: "TblCaseProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Option",
                table: "TblCaseProduct",
                type: "varchar(300)",
                maxLength: 300,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProduct_MethodId",
                table: "TblCaseProduct",
                column: "MethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseProduct_TblMethod_MethodId",
                table: "TblCaseProduct",
                column: "MethodId",
                principalTable: "TblMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseProduct_TblMethod_MethodId",
                table: "TblCaseProduct");

            migrationBuilder.DropIndex(
                name: "IX_TblCaseProduct_MethodId",
                table: "TblCaseProduct");

            migrationBuilder.DropColumn(
                name: "MethodId",
                table: "TblCaseProduct");

            migrationBuilder.DropColumn(
                name: "Option",
                table: "TblCaseProduct");

            migrationBuilder.AddColumn<int>(
                name: "MethodId",
                table: "TblCase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "TblCase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TblCase_MethodId",
                table: "TblCase",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCase_ProductTypeId",
                table: "TblCase",
                column: "ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCase_TblMethod_MethodId",
                table: "TblCase",
                column: "MethodId",
                principalTable: "TblMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCase_TblProductType_ProductTypeId",
                table: "TblCase",
                column: "ProductTypeId",
                principalTable: "TblProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
