using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddOnStickerInOrthopedicAndOrthodontic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 6, 18, 14, 19, 508, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 1, 15, 46, 34, 861, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.InsertData(
                table: "TblAddOn",
                columns: new[] { "Id", "Code", "ColorCode", "DisplayName", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 44, "", "", "Acrylic Plate", "", "Acrylic Plate" },
                    { 45, "", "", "Acrylic Plate", "", "Labial Plate" },
                    { 46, "", "", "Acrylic Plate", "", "Buccal Plate" },
                    { 47, "", "", "Sticker", "", "Sticker" },
                    { 48, "", "", "Glitter", "", "Glitter" }
                });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 47,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 48,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 49,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 50,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 51,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 52,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 53,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 54,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 55,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 56,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 57,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 58,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 59,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 60,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 61,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 62,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 63,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 64,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 65,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 66,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 67,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 68,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 69,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 70,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 71,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 72,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 73,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 74,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 75,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 76,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 77,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 78,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 79,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 80,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 81,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 82,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 83,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 84,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 85,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 86,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 87,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 89,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 90,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 91,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 92,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 93,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 94,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 95,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 96,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 97,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 98,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 99,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 100,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 101,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 102,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 103,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 104,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 105,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 106,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 107,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 108,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 109,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 110,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "InputType", "RequiredInput" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "InputType", "RequiredInput" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "InputType", "RequiredInput" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 114,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 115,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 116,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 117,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 118,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 119,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 120,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 121,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 122,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 123,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 124,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 125,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 126,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 127,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 128,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 129,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 130,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 131,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 132,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 133,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 134,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 135,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 136,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 137,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 138,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 139,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 140,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 141,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 142,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 143,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 144,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 145,
                column: "InputType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(1970), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3771), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3781), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3783), new DateTime(2021, 7, 6, 18, 14, 19, 511, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.InsertData(
                table: "TblProductAddOn",
                columns: new[] { "Id", "AddOnId", "GroupAddOnId", "InputType", "MasterProductId", "RequiredInput" },
                values: new object[,]
                {
                    { 201, 44, null, 5, 55, true },
                    { 168, 46, null, 8, 80, true },
                    { 173, 46, null, 8, 82, true },
                    { 178, 46, null, 8, 83, true },
                    { 183, 46, null, 8, 84, true },
                    { 188, 46, null, 8, 86, true },
                    { 204, 47, null, 6, 55, true },
                    { 209, 47, null, 6, 56, true },
                    { 149, 47, null, 6, 62, true },
                    { 154, 47, null, 6, 63, true },
                    { 159, 47, null, 6, 64, true },
                    { 194, 47, null, 6, 87, true },
                    { 199, 47, null, 6, 88, true },
                    { 164, 47, null, 6, 79, true },
                    { 169, 47, null, 6, 80, true },
                    { 174, 47, null, 6, 82, true },
                    { 179, 47, null, 6, 83, true },
                    { 184, 47, null, 6, 84, true },
                    { 189, 47, null, 6, 86, true },
                    { 205, 48, null, 9, 55, true },
                    { 210, 48, null, 9, 56, true },
                    { 150, 48, null, 9, 62, true },
                    { 155, 48, null, 9, 63, true },
                    { 160, 48, null, 9, 64, true },
                    { 195, 48, null, 9, 87, true },
                    { 200, 48, null, 9, 88, true },
                    { 165, 48, null, 9, 79, true },
                    { 170, 48, null, 9, 80, true },
                    { 175, 48, null, 9, 82, true },
                    { 180, 48, null, 9, 83, true },
                    { 163, 46, null, 8, 79, true },
                    { 185, 48, null, 9, 84, true },
                    { 198, 46, null, 8, 88, true },
                    { 158, 46, null, 8, 64, true },
                    { 206, 44, null, 5, 56, true },
                    { 146, 44, null, 5, 62, true },
                    { 151, 44, null, 5, 63, true },
                    { 156, 44, null, 5, 64, true },
                    { 191, 44, null, 5, 87, true },
                    { 196, 44, null, 5, 88, true },
                    { 161, 44, null, 5, 79, true },
                    { 166, 44, null, 5, 80, true },
                    { 171, 44, null, 5, 82, true },
                    { 176, 44, null, 5, 83, true },
                    { 181, 44, null, 5, 84, true },
                    { 186, 44, null, 5, 86, true },
                    { 202, 45, null, 7, 55, true },
                    { 207, 45, null, 7, 56, true },
                    { 147, 45, null, 7, 62, true },
                    { 152, 45, null, 7, 63, true },
                    { 157, 45, null, 7, 64, true },
                    { 192, 45, null, 7, 87, true },
                    { 197, 45, null, 7, 88, true },
                    { 162, 45, null, 7, 79, true },
                    { 167, 45, null, 7, 80, true },
                    { 172, 45, null, 7, 82, true },
                    { 177, 45, null, 7, 83, true },
                    { 182, 45, null, 7, 84, true },
                    { 187, 45, null, 7, 86, true },
                    { 203, 46, null, 8, 55, true },
                    { 208, 46, null, 8, 56, true },
                    { 148, 46, null, 8, 62, true },
                    { 153, 46, null, 8, 63, true },
                    { 193, 46, null, 8, 87, true },
                    { 190, 48, null, 9, 86, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 15, 46, 34, 861, DateTimeKind.Local).AddTicks(7527),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 6, 18, 14, 19, 508, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 47,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 48,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 49,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 50,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 51,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 52,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 53,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 54,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 55,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 56,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 57,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 58,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 59,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 60,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 61,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 62,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 63,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 64,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 65,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 66,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 67,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 68,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 69,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 70,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 71,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 72,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 73,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 74,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 75,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 76,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 77,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 78,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 79,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 80,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 81,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 82,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 83,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 84,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 85,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 86,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 87,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 89,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 90,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 91,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 92,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 93,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 94,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 95,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 96,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 97,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 98,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 99,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 100,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 101,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 102,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 103,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 104,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 105,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 106,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 107,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 108,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 109,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 110,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "InputType", "RequiredInput" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "InputType", "RequiredInput" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "InputType", "RequiredInput" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 114,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 115,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 116,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 117,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 118,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 119,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 120,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 121,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 122,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 123,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 124,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 125,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 126,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 127,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 128,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 129,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 130,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 131,
                column: "InputType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 132,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 133,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 134,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 135,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 136,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 137,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 138,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 139,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 140,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 141,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 142,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 143,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 144,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 145,
                column: "InputType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(1338), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4564), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4578), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4581), new DateTime(2021, 7, 1, 15, 46, 34, 866, DateTimeKind.Local).AddTicks(4582) });
        }
    }
}
