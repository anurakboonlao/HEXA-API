using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddOnGroup_TemporaryPartialPlate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 11, 45, 30, 368, DateTimeKind.Local).AddTicks(8018),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 18, 27, 22, 506, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "High Impact for TP", "High Impact for TP" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Acrylic Gum slip", "Acrylic Gum slip" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Overlay Denture", "Overlay Denture" });

            migrationBuilder.InsertData(
                table: "TblGroupAddOn",
                columns: new[] { "Id", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 3, "ตะขอ", 1 },
                    { 4, "ตะแกรง", 2 },
                    { 5, "อื่นๆ", 3 }
                });

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

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 23,
                column: "GroupAddOnId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 24,
                column: "GroupAddOnId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 25,
                column: "GroupAddOnId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 26,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 27,
                column: "GroupAddOnId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 28,
                column: "GroupAddOnId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 29,
                column: "GroupAddOnId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 30,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 31,
                column: "GroupAddOnId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 32,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 33,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 34,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 35,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 36,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 37,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 38,
                column: "GroupAddOnId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 39,
                column: "GroupAddOnId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 40,
                column: "GroupAddOnId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 18, 27, 22, 506, DateTimeKind.Local).AddTicks(6509),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 30, 11, 45, 30, 368, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "High Impact for TP (คิดเพิ่ม)", "High Impact for TP (คิดเพิ่ม)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Acrylic Gum slip (ต่อชิ้น)", "Acrylic Gum slip (ต่อชิ้น)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Overlay Denture (ซี่ละ)", "Overlay Denture (ซี่ละ)" });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 23,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 24,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 25,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 26,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 27,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 28,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 29,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 30,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 31,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 32,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 33,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 34,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 35,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 36,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 37,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 38,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 39,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 40,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(684), new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(3785), new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(3794), new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(3797), new DateTime(2021, 6, 29, 18, 27, 22, 510, DateTimeKind.Local).AddTicks(3798) });
        }
    }
}
