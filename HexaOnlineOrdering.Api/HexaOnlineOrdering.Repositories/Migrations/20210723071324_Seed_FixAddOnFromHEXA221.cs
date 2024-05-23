using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_FixAddOnFromHEXA221 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 23, 14, 13, 22, 817, DateTimeKind.Local).AddTicks(6976),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 23, 10, 16, 35, 685, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45,
                column: "DisplayName",
                value: "Labial Acrylic");

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "DisplayName",
                value: "Buccal Acrylic");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Bionator to Open,to Close,to Hold");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "Celar Bow (Included Acrylic Plate)");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "Setup Tooth with Clear Aligner");

            migrationBuilder.InsertData(
                table: "TblProductAddOn",
                columns: new[] { "Id", "AddOnId", "GroupAddOnId", "InputType", "MasterProductId", "RequiredInput" },
                values: new object[,]
                {
                    { 211, 39, null, 4, 22, true },
                    { 258, 39, null, 4, 51, true },
                    { 259, 39, null, 4, 52, true },
                    { 260, 39, null, 4, 53, true },
                    { 261, 39, null, 4, 54, true },
                    { 221, 44, null, 5, 58, true },
                    { 222, 45, null, 7, 58, true },
                    { 223, 46, null, 8, 58, true },
                    { 224, 47, null, 6, 58, true },
                    { 225, 48, null, 9, 58, true },
                    { 218, 46, null, 8, 32, true },
                    { 217, 45, null, 7, 32, true },
                    { 250, 48, null, 9, 26, true },
                    { 219, 47, null, 6, 32, true },
                    { 220, 48, null, 9, 32, true },
                    { 251, 44, null, 5, 89, true },
                    { 252, 45, null, 7, 89, true },
                    { 253, 46, null, 8, 89, true },
                    { 256, 47, null, 6, 89, true },
                    { 257, 48, null, 9, 89, true },
                    { 216, 44, null, 5, 32, true },
                    { 248, 46, null, 8, 26, true },
                    { 249, 47, null, 6, 26, true },
                    { 213, 39, null, 4, 24, true },
                    { 226, 44, null, 5, 22, true },
                    { 227, 45, null, 7, 22, true },
                    { 228, 46, null, 8, 22, true },
                    { 229, 47, null, 6, 22, true },
                    { 230, 48, null, 9, 22, true },
                    { 212, 39, null, 4, 23, true },
                    { 231, 44, null, 5, 23, true },
                    { 232, 45, null, 7, 23, true },
                    { 233, 46, null, 8, 23, true },
                    { 234, 47, null, 6, 23, true },
                    { 235, 48, null, 9, 23, true },
                    { 247, 45, null, 7, 26, true },
                    { 236, 44, null, 5, 24, true },
                    { 237, 45, null, 7, 24, true },
                    { 238, 46, null, 8, 24, true },
                    { 239, 47, null, 6, 24, true },
                    { 240, 48, null, 9, 24, true },
                    { 214, 39, null, 4, 25, true },
                    { 241, 44, null, 5, 25, true },
                    { 242, 45, null, 7, 25, true },
                    { 243, 46, null, 8, 25, true },
                    { 244, 47, null, 6, 25, true },
                    { 245, 48, null, 9, 25, true },
                    { 215, 39, null, 4, 26, true },
                    { 246, 44, null, 5, 26, true }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 14, 13, 22, 820, DateTimeKind.Local).AddTicks(7341), new DateTime(2021, 7, 23, 14, 13, 22, 820, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 14, 13, 22, 820, DateTimeKind.Local).AddTicks(9943), new DateTime(2021, 7, 23, 14, 13, 22, 820, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 14, 13, 22, 820, DateTimeKind.Local).AddTicks(9974), new DateTime(2021, 7, 23, 14, 13, 22, 820, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 14, 13, 22, 821, DateTimeKind.Local).AddTicks(10), new DateTime(2021, 7, 23, 14, 13, 22, 821, DateTimeKind.Local).AddTicks(11) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 23, 10, 16, 35, 685, DateTimeKind.Local).AddTicks(2278),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 23, 14, 13, 22, 817, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45,
                column: "DisplayName",
                value: "Labial Plate");

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "DisplayName",
                value: "Buccal Plate");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Bionater to Open,to Close,to Hold");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "Clear Blow (Included Acrylic Plate)");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "Clear Aligner");

            migrationBuilder.InsertData(
                table: "TblProductAddOn",
                columns: new[] { "Id", "AddOnId", "GroupAddOnId", "InputType", "MasterProductId", "RequiredInput" },
                values: new object[,]
                {
                    { 73, 35, null, 4, 25, true },
                    { 74, 36, null, 4, 25, true },
                    { 172, 45, null, 7, 82, true },
                    { 173, 46, null, 8, 82, true }
                });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[] { 94, 94, 8 });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 687, DateTimeKind.Local).AddTicks(9134), new DateTime(2021, 7, 23, 10, 16, 35, 687, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(898), new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(900), new DateTime(2021, 7, 23, 10, 16, 35, 688, DateTimeKind.Local).AddTicks(901) });
        }
    }
}
