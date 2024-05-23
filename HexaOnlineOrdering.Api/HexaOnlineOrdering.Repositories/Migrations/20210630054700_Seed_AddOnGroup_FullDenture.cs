using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddOnGroup_FullDenture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 12, 46, 59, 811, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 11, 45, 30, 368, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.InsertData(
                table: "TblGroupAddOn",
                columns: new[] { "Id", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 6, "ตะแกรง", 1 },
                    { 7, "ตะขอ", 2 },
                    { 8, "อื่นๆ", 3 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 814, DateTimeKind.Local).AddTicks(7284), new DateTime(2021, 6, 30, 12, 46, 59, 814, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(326), new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(337), new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(340), new DateTime(2021, 6, 30, 12, 46, 59, 815, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupAddOnId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 2,
                column: "GroupAddOnId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 3,
                column: "GroupAddOnId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 4,
                column: "GroupAddOnId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 5,
                column: "GroupAddOnId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 6,
                column: "GroupAddOnId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 7,
                column: "GroupAddOnId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 8,
                column: "GroupAddOnId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 9,
                column: "GroupAddOnId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 10,
                column: "GroupAddOnId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 11,
                column: "GroupAddOnId",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 11, 45, 30, 368, DateTimeKind.Local).AddTicks(8018),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 12, 46, 59, 811, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 2,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 3,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 4,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 5,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 6,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 7,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 8,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 9,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 10,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 11,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(2386), new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(5048), new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(5058), new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(5060), new DateTime(2021, 6, 30, 11, 45, 30, 372, DateTimeKind.Local).AddTicks(5061) });
        }
    }
}
