using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_Catalog2022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 25, 22, 27, 52, 573, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 11, 4, 15, 10, 19, 672, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.InsertData(
                table: "TblCatalog",
                columns: new[] { "Id", "CatalogGroupId", "LogoPath", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 99, 1, "/Catalog/22_901.jpg", "Red 901", 1 },
                    { 169, 1, "/Catalog/HC46.jpg", "HC 46", 71 },
                    { 168, 1, "/Catalog/HC45.jpg", "HC 45", 70 },
                    { 167, 1, "/Catalog/HC44.jpg", "HC 44", 69 },
                    { 166, 1, "/Catalog/HC43.jpg", "HC 43", 68 },
                    { 165, 1, "/Catalog/HC42.jpg", "HC 42", 67 },
                    { 164, 1, "/Catalog/HC41.jpg", "HC 41", 66 },
                    { 163, 1, "/Catalog/HC40.jpg", "HC 40", 65 },
                    { 162, 1, "/Catalog/HC39.jpg", "HC 39", 64 },
                    { 161, 1, "/Catalog/HC38.jpg", "HC 38", 63 },
                    { 170, 1, "/Catalog/HC47.jpg", "HC 47", 72 },
                    { 160, 1, "/Catalog/HC37.jpg", "HC 37", 62 },
                    { 158, 1, "/Catalog/HC35.jpg", "HC 35", 60 },
                    { 157, 1, "/Catalog/HC34.jpg", "HC 34", 59 },
                    { 156, 1, "/Catalog/HC33.jpg", "HC 33", 58 },
                    { 155, 1, "/Catalog/HC32.jpg", "HC 32", 57 },
                    { 154, 1, "/Catalog/HC31.jpg", "HC 31", 56 },
                    { 153, 1, "/Catalog/HC30.jpg", "HC 30", 55 },
                    { 152, 1, "/Catalog/HC29.jpg", "HC 29", 54 },
                    { 151, 1, "/Catalog/HC28.jpg", "HC 28", 53 },
                    { 150, 1, "/Catalog/HC27.jpg", "HC 27", 52 },
                    { 159, 1, "/Catalog/HC36.jpg", "HC 36", 61 },
                    { 149, 1, "/Catalog/HC26.jpg", "HC 26", 51 },
                    { 171, 1, "/Catalog/HC48.jpg", "HC 48", 73 },
                    { 173, 1, "/Catalog/HC50.jpg", "HC 50", 75 },
                    { 193, 2, "/Catalog/glitter-pink.jpg", "Glitter Pink", 95 },
                    { 192, 2, "/Catalog/glitter-purple.jpg", "Glitter Purple", 94 },
                    { 191, 2, "/Catalog/glitter-gold.jpg", "Glitter Gold", 93 },
                    { 190, 2, "/Catalog/glitter-colorful.jpg", "Glitter Colorful", 92 },
                    { 189, 2, "/Catalog/glitter-blue.jpg", "Glitter Blue", 91 },
                    { 188, 2, "/Catalog/glitter-red.jpg", "Glitter Red", 90 },
                    { 187, 2, "/Catalog/glitter-silver.jpg", "Glitter Silver", 89 },
                    { 186, 2, "/Catalog/glitter-green.jpg", "Glitter Green", 88 },
                    { 185, 1, "/Catalog/HC62.jpg", "HC 62", 87 },
                    { 172, 1, "/Catalog/HC49.jpg", "HC 49", 74 },
                    { 184, 1, "/Catalog/HC61.jpg", "HC 61", 86 },
                    { 182, 1, "/Catalog/HC59.jpg", "HC 59", 84 },
                    { 181, 1, "/Catalog/HC58.jpg", "HC 58", 83 },
                    { 180, 1, "/Catalog/HC57.jpg", "HC 57", 82 },
                    { 179, 1, "/Catalog/HC56.jpg", "HC 56", 81 },
                    { 178, 1, "/Catalog/HC55.jpg", "HC 55", 80 },
                    { 177, 1, "/Catalog/HC54.jpg", "HC 54", 79 },
                    { 176, 1, "/Catalog/HC53.jpg", "HC 53", 78 },
                    { 175, 1, "/Catalog/HC52.jpg", "HC 52", 77 },
                    { 174, 1, "/Catalog/HC51.jpg", "HC 51", 76 },
                    { 183, 1, "/Catalog/HC60.jpg", "HC 60", 85 },
                    { 147, 1, "/Catalog/HC24.jpg", "HC 24", 49 },
                    { 148, 1, "/Catalog/HC25.jpg", "HC 25", 50 },
                    { 145, 1, "/Catalog/HC22.jpg", "HC 22", 47 },
                    { 120, 1, "/Catalog/22_A903.jpg", "Blue A903", 22 },
                    { 119, 1, "/Catalog/22_A902.jpg", "Yellow A902", 21 },
                    { 118, 1, "/Catalog/22_A901.jpg", "Red A901", 20 },
                    { 117, 1, "/Catalog/22_923.jpg", "Pink Tone 923", 19 },
                    { 116, 1, "/Catalog/22_922.jpg", "Clear 922 ขาวใส", 18 },
                    { 115, 1, "/Catalog/22_921.jpg", "Pink Opaque 921", 17 },
                    { 114, 1, "/Catalog/22_917.jpg", "Neon Pink 917", 16 },
                    { 113, 1, "/Catalog/22_916.jpg", "Neon Orange 916", 15 },
                    { 112, 1, "/Catalog/22_915.jpg", "Neon Green 915", 14 },
                    { 111, 1, "/Catalog/22_914.jpg", "Neon Yellow 914", 13 },
                    { 110, 1, "/Catalog/22_913.jpg", "Magenta 913", 12 },
                    { 109, 1, "/Catalog/22_912.jpg", "Black 912", 11 },
                    { 108, 1, "/Catalog/22_910.jpg", "Violet 910", 10 },
                    { 107, 1, "/Catalog/22_909.jpg", "White 909 ขาวทึบ", 9 },
                    { 106, 1, "/Catalog/22_908.jpg", "Turquoise 908", 8 },
                    { 105, 1, "/Catalog/22_907.jpg", "Purple 907", 7 },
                    { 104, 1, "/Catalog/22_906.jpg", "Blue 906", 6 },
                    { 103, 1, "/Catalog/22_905.jpg", "Blue 905", 5 },
                    { 102, 1, "/Catalog/22_904.jpg", "Green 904", 4 },
                    { 101, 1, "/Catalog/22_903.jpg", "Blue 903", 3 },
                    { 100, 1, "/Catalog/22_902.jpg", "Yellow 902", 2 },
                    { 146, 1, "/Catalog/HC23.jpg", "HC 23", 48 },
                    { 122, 1, "/Catalog/22_A913.jpg", "Megenta A913", 24 },
                    { 121, 1, "/Catalog/22_A907.jpg", "Purple A907", 23 },
                    { 124, 1, "/Catalog/HC01.jpg", "HC 01", 26 },
                    { 144, 1, "/Catalog/HC18.jpg", "HC 18", 46 },
                    { 143, 1, "/Catalog/HC17.jpg", "HC 17", 45 },
                    { 142, 1, "/Catalog/HC16.jpg", "HC 16", 44 },
                    { 141, 1, "/Catalog/HC12.jpg", "HC 12", 43 },
                    { 140, 1, "/Catalog/HC11.jpg", "HC 11", 42 },
                    { 139, 1, "/Catalog/HC10.jpg", "HC 10", 41 },
                    { 138, 1, "/Catalog/HC06.jpg", "HC 06", 40 },
                    { 137, 1, "/Catalog/HC05.jpg", "HC 05", 39 },
                    { 123, 1, "/Catalog/22_A923.jpg", "Pink Tone A923", 25 },
                    { 135, 1, "/Catalog/HC21.jpg", "HC 21", 37 },
                    { 136, 1, "/Catalog/HC04.jpg", "HC 04", 38 },
                    { 133, 1, "/Catalog/HC19.jpg", "HC 19", 35 },
                    { 132, 1, "/Catalog/HC15.jpg", "HC 15", 34 },
                    { 131, 1, "/Catalog/HC14.jpg", "HC 14", 33 },
                    { 130, 1, "/Catalog/HC13.jpg", "HC 13", 32 },
                    { 129, 1, "/Catalog/HC09.jpg", "HC 09", 31 },
                    { 128, 1, "/Catalog/HC08.jpg", "HC 08", 30 },
                    { 127, 1, "/Catalog/HC07.jpg", "HC 07", 29 },
                    { 126, 1, "/Catalog/HC03.jpg", "HC 03", 28 },
                    { 125, 1, "/Catalog/HC02.jpg", "HC 02", 27 },
                    { 134, 1, "/Catalog/HC20.jpg", "HC 20", 36 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5288), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5295), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5298), new DateTime(2022, 8, 25, 22, 27, 52, 576, DateTimeKind.Local).AddTicks(5299) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 15, 10, 19, 672, DateTimeKind.Local).AddTicks(5336),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 8, 25, 22, 27, 52, 573, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(3617), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6143), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6160), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 11, 4, 15, 10, 19, 676, DateTimeKind.Local).AddTicks(6164) });
        }
    }
}
