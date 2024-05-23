using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_TblGroupAddOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupAddOnId",
                table: "TblProductAddOn",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 17, 35, 1, 693, DateTimeKind.Local).AddTicks(7758),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 16, 40, 29, 351, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.CreateTable(
                name: "TblGroupAddOn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGroupAddOn", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 17, 35, 1, 696, DateTimeKind.Local).AddTicks(7192), new DateTime(2021, 6, 29, 17, 35, 1, 696, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(39), new DateTime(2021, 6, 29, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(49), new DateTime(2021, 6, 29, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(52), new DateTime(2021, 6, 29, 17, 35, 1, 697, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.CreateIndex(
                name: "IX_TblProductAddOn_GroupAddOnId",
                table: "TblProductAddOn",
                column: "GroupAddOnId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductAddOn_TblGroupAddOn_GroupAddOnId",
                table: "TblProductAddOn",
                column: "GroupAddOnId",
                principalTable: "TblGroupAddOn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblProductAddOn_TblGroupAddOn_GroupAddOnId",
                table: "TblProductAddOn");

            migrationBuilder.DropTable(
                name: "TblGroupAddOn");

            migrationBuilder.DropIndex(
                name: "IX_TblProductAddOn_GroupAddOnId",
                table: "TblProductAddOn");

            migrationBuilder.DropColumn(
                name: "GroupAddOnId",
                table: "TblProductAddOn");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 16, 40, 29, 351, DateTimeKind.Local).AddTicks(6105),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 17, 35, 1, 693, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(4760), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7377), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7385), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7388), new DateTime(2021, 6, 29, 16, 40, 29, 354, DateTimeKind.Local).AddTicks(7389) });
        }
    }
}
