using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddOnGroup_PartialDentureFramework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 18, 27, 22, 506, DateTimeKind.Local).AddTicks(6509),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 17, 35, 1, 693, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "ฐานนิ่ม (Soft base vertex)", "ฐานนิ่ม (Soft base vertex)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "ฐานนิ่มบางตำแหน่ง (Soft base vertex)", "ฐานนิ่มบางตำแหน่ง (Soft base vertex)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "High Impact for Full Denture", "High Impact for Full Denture" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "ฟัน Acetal บนโครง RPD", "ฟัน Acetal บนโครง RPD" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Full Metal Tooth", "Full Metal Tooth" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Backing", "Backing" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Acetal Clasp (ตะขอสีเหมือนฟัน)", "Acetal Clasp (ตะขอสีเหมือนฟัน)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "High Impact for RPD", "High Impact for RPD" });

            migrationBuilder.InsertData(
                table: "TblGroupAddOn",
                columns: new[] { "Id", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 1, "ตะขอ", 1 },
                    { 2, "อื่นๆ", 2 }
                });

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

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 12,
                column: "GroupAddOnId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 13,
                column: "GroupAddOnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 14,
                column: "GroupAddOnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 15,
                column: "GroupAddOnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 16,
                column: "GroupAddOnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 17,
                column: "GroupAddOnId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 18,
                column: "GroupAddOnId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 19,
                column: "GroupAddOnId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 20,
                column: "GroupAddOnId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 21,
                column: "GroupAddOnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 22,
                column: "GroupAddOnId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblGroupAddOn",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 17, 35, 1, 693, DateTimeKind.Local).AddTicks(7758),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 18, 27, 22, 506, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "งานฐานนิ่ม (Softbase vertex)", "งานฐานนิ่ม (Softbase vertex)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "เติมฐานนิ่มบางตำแหน่ง (ตำแหน่งละ) (Vertex)", "เติมฐานนิ่มบางตำแหน่ง (ตำแหน่งละ) (Vertex)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "High Impact for Full Denture (คิดเพิ่ม)", "High Impact for Full Denture (คิดเพิ่ม)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "ฟัน Acetal บนโครง RPD (ซี่ละ)", "ฟัน Acetal บนโครง RPD (ซี่ละ)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Full Metal Tooth (คิดเพิ่มซี่ละ)", "Full Metal Tooth (คิดเพิ่มซี่ละ)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Backing (คิดเพิ่มซี่ละ)", "Backing (คิดเพิ่มซี่ละ)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "Acetal Clasp ตะขอสีเหมือนฟัน (ตะขอละ)", "Acetal Clasp ตะขอสีเหมือนฟัน (ตะขอละ)" });

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisplayName", "Name" },
                values: new object[] { "High Impact for RPD (คิดเพิ่ม)", "High Impact for RPD (คิดเพิ่ม)" });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 12,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 13,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 14,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 15,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 16,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 17,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 18,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 19,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 20,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 21,
                column: "GroupAddOnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 22,
                column: "GroupAddOnId",
                value: null);

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
        }
    }
}
