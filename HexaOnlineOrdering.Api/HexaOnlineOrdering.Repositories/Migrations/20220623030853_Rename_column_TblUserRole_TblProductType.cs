using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Rename_column_TblUserRole_TblProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblProductType_ProductTypeIdId",
                table: "TblProductTypeTblUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblUserRole_UserRoleIdId",
                table: "TblProductTypeTblUserRole");

            migrationBuilder.RenameColumn(
                name: "UserRoleIdId",
                table: "TblProductTypeTblUserRole",
                newName: "UserRoleId");

            migrationBuilder.RenameColumn(
                name: "ProductTypeIdId",
                table: "TblProductTypeTblUserRole",
                newName: "ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TblProductTypeTblUserRole_UserRoleIdId",
                table: "TblProductTypeTblUserRole",
                newName: "IX_TblProductTypeTblUserRole_UserRoleId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 23, 10, 8, 51, 1, DateTimeKind.Local).AddTicks(5605),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 21, 13, 59, 3, 199, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(3114), new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(5543), new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(5556), new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(5559), new DateTime(2022, 6, 23, 10, 8, 51, 9, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblProductType_ProductTypeId",
                table: "TblProductTypeTblUserRole",
                column: "ProductTypeId",
                principalTable: "TblProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblUserRole_UserRoleId",
                table: "TblProductTypeTblUserRole",
                column: "UserRoleId",
                principalTable: "TblUserRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblProductType_ProductTypeId",
                table: "TblProductTypeTblUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblUserRole_UserRoleId",
                table: "TblProductTypeTblUserRole");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "TblProductTypeTblUserRole",
                newName: "UserRoleIdId");

            migrationBuilder.RenameColumn(
                name: "ProductTypeId",
                table: "TblProductTypeTblUserRole",
                newName: "ProductTypeIdId");

            migrationBuilder.RenameIndex(
                name: "IX_TblProductTypeTblUserRole_UserRoleId",
                table: "TblProductTypeTblUserRole",
                newName: "IX_TblProductTypeTblUserRole_UserRoleIdId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 21, 13, 59, 3, 199, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 6, 23, 10, 8, 51, 1, DateTimeKind.Local).AddTicks(5605));

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

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblProductType_ProductTypeIdId",
                table: "TblProductTypeTblUserRole",
                column: "ProductTypeIdId",
                principalTable: "TblProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProductTypeTblUserRole_TblUserRole_UserRoleIdId",
                table: "TblProductTypeTblUserRole",
                column: "UserRoleIdId",
                principalTable: "TblUserRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
