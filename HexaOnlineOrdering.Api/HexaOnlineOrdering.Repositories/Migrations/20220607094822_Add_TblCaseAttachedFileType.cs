using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Add_TblCaseAttachedFileType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNotification",
                table: "TblOrder",
                type: "tinyint(1)",
                nullable: false,
                defaultValueSql: "'0'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 7, 16, 48, 21, 389, DateTimeKind.Local).AddTicks(2205),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 1, 16, 12, 7, 641, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.AddColumn<int>(
                name: "FileTypeId",
                table: "TblCaseAttachedFile",
                type: "int",
                nullable: false,
                defaultValueSql: "'1'");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "TblCase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "TblCase",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TblCaseAttachedFileType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCaseAttachedFileType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.InsertData(
                table: "TblCaseAttachedFileType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "normal" },
                    { 2, "ICHARM patient image" },
                    { 3, "ICHARM x-ray" },
                    { 4, "ICHARM case presentation" }
                });

            migrationBuilder.InsertData(
                table: "TblProductType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "ICHARM" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4184), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4187), new DateTime(2022, 6, 7, 16, 48, 21, 394, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.InsertData(
                table: "TblMasterProduct",
                columns: new[] { "Id", "Code", "ColorCode", "ExpectedProductDay", "LogoPath", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 144, null, null, 3, null, "Canine to Canine", 5 },
                    { 145, null, null, 3, null, "Premolar to Premolar", 5 }
                });

            migrationBuilder.InsertData(
                table: "TblMethod",
                columns: new[] { "Id", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 15, "Finish", 5 },
                    { 16, "Remake", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProduct_ShadeId",
                table: "TblCaseProduct",
                column: "ShadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseProduct_ShadeSystemId",
                table: "TblCaseProduct",
                column: "ShadeSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCaseAttachedFile_FileTypeId",
                table: "TblCaseAttachedFile",
                column: "FileTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseAttachedFile_TblCaseAttachedFileType_FileTypeId",
                table: "TblCaseAttachedFile",
                column: "FileTypeId",
                principalTable: "TblCaseAttachedFileType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseProduct_TblShade_ShadeId",
                table: "TblCaseProduct",
                column: "ShadeId",
                principalTable: "TblShade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCaseProduct_TblShadeSystem_ShadeSystemId",
                table: "TblCaseProduct",
                column: "ShadeSystemId",
                principalTable: "TblShadeSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseAttachedFile_TblCaseAttachedFileType_FileTypeId",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseProduct_TblShade_ShadeId",
                table: "TblCaseProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCaseProduct_TblShadeSystem_ShadeSystemId",
                table: "TblCaseProduct");

            migrationBuilder.DropTable(
                name: "TblCaseAttachedFileType");

            migrationBuilder.DropIndex(
                name: "IX_TblCaseProduct_ShadeId",
                table: "TblCaseProduct");

            migrationBuilder.DropIndex(
                name: "IX_TblCaseProduct_ShadeSystemId",
                table: "TblCaseProduct");

            migrationBuilder.DropIndex(
                name: "IX_TblCaseAttachedFile_FileTypeId",
                table: "TblCaseAttachedFile");

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblProductType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "IsNotification",
                table: "TblOrder");

            migrationBuilder.DropColumn(
                name: "FileTypeId",
                table: "TblCaseAttachedFile");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "TblCase");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TblCase");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 1, 16, 12, 7, 641, DateTimeKind.Local).AddTicks(1160),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 7, 16, 48, 21, 389, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 647, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 6, 1, 16, 12, 7, 647, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2110), new DateTime(2022, 6, 1, 16, 12, 7, 648, DateTimeKind.Local).AddTicks(2120) });
        }
    }
}
