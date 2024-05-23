using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class ChangeProductAddOnColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputType",
                table: "TblAddOn");

            migrationBuilder.DropColumn(
                name: "RequiredInput",
                table: "TblAddOn");

            migrationBuilder.AddColumn<int>(
                name: "InputType",
                table: "TblProductAddOn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequiredInput",
                table: "TblProductAddOn",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "InputAddOn",
                table: "TblFavoriteAddOn",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "InputAddOn",
                table: "TblCaseProductAddOn",
                type: "varchar(5)",
                maxLength: 5,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputType",
                table: "TblProductAddOn");

            migrationBuilder.DropColumn(
                name: "RequiredInput",
                table: "TblProductAddOn");

            migrationBuilder.DropColumn(
                name: "InputAddOn",
                table: "TblFavoriteAddOn");

            migrationBuilder.DropColumn(
                name: "InputAddOn",
                table: "TblCaseProductAddOn");

            migrationBuilder.AddColumn<int>(
                name: "InputType",
                table: "TblAddOn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequiredInput",
                table: "TblAddOn",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
