using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_CatalogAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 4, 10, 6, 22, 35, DateTimeKind.Local).AddTicks(5862),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 3, 15, 32, 51, 876, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.InsertData(
                table: "TblCatalog",
                columns: new[] { "Id", "CatalogGroupId", "LogoPath", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 1, 1, "/Catalog/901.png", "Red 901", 1 },
                    { 73, 1, "/Catalog/087.jpg", "087", 90 },
                    { 72, 1, "/Catalog/086.jpg", "086", 89 },
                    { 71, 1, "/Catalog/085.jpg", "085", 88 },
                    { 70, 1, "/Catalog/084.jpg", "084", 87 },
                    { 69, 1, "/Catalog/083.jpg", "083", 86 },
                    { 68, 1, "/Catalog/082.jpg", "082", 85 },
                    { 67, 1, "/Catalog/081.jpg", "081", 84 },
                    { 66, 1, "/Catalog/080.jpg", "080", 83 },
                    { 65, 1, "/Catalog/079.jpg", "079", 82 },
                    { 64, 1, "/Catalog/078.jpg", "078", 81 },
                    { 63, 1, "/Catalog/077.jpg", "077", 80 },
                    { 62, 1, "/Catalog/076.jpg", "076", 79 },
                    { 61, 1, "/Catalog/075.jpg", "075", 78 },
                    { 60, 1, "/Catalog/074.jpg", "074", 77 },
                    { 59, 1, "/Catalog/073.jpg", "073", 76 },
                    { 58, 1, "/Catalog/072.jpg", "072", 75 },
                    { 57, 1, "/Catalog/071.jpg", "071", 74 },
                    { 56, 1, "/Catalog/070.jpg", "070", 73 },
                    { 55, 1, "/Catalog/069.jpg", "060", 72 },
                    { 54, 1, "/Catalog/068.jpg", "068", 71 },
                    { 53, 1, "/Catalog/067.jpg", "067", 70 },
                    { 74, 1, "/Catalog/088.jpg", "088", 91 },
                    { 52, 1, "/Catalog/066.jpg", "066", 69 },
                    { 75, 1, "/Catalog/089.jpg", "089", 92 },
                    { 77, 1, "/Catalog/H01.jpg", "H01", 100 },
                    { 98, 2, "/Catalog/Glitter-Yellow.png", "Glitter Yellow", 35 },
                    { 97, 2, "/Catalog/Glitter-Pink.png", "Glitter Pink", 34 },
                    { 96, 2, "/Catalog/Glitter-Purple.png", "Glitter Purple", 33 },
                    { 95, 2, "/Catalog/Glitter-Orange.png", "Glitter Orange", 32 },
                    { 94, 2, "/Catalog/Glitter-Colorful.png", "Glitter Colorful", 31 },
                    { 93, 2, "/Catalog/Glitter-Blue.png", "Glitter Blue", 30 },
                    { 92, 2, "/Catalog/Glitter-Red.png", "Glitter Red", 29 },
                    { 91, 2, "/Catalog/Glitter-Silver.png", "Glitter Silver", 28 },
                    { 90, 2, "/Catalog/Glitter-Green.png", "Glitter Green", 27 },
                    { 89, 2, "/Catalog/Glitter-Gold.png", "Glitter Gold", 26 },
                    { 88, 1, "/Catalog/A913.png", "Magenta A913", 25 },
                    { 87, 1, "/Catalog/A907.png", "Purple A907", 24 },
                    { 86, 1, "/Catalog/A903.png", "Blue A903", 23 },
                    { 85, 1, "/Catalog/A902.png", "Yellow A902", 22 },
                    { 84, 1, "/Catalog/A901.png", "Red A901", 21 },
                    { 83, 1, "/Catalog/H29.jpg", "H29", 106 },
                    { 82, 1, "/Catalog/H21.jpg", "H21", 105 },
                    { 81, 1, "/Catalog/H19.jpg", "H19", 104 },
                    { 80, 1, "/Catalog/H09.jpg", "H09", 103 },
                    { 79, 1, "/Catalog/H07.jpg", "H07", 102 },
                    { 78, 1, "/Catalog/H05.jpg", "H05", 101 },
                    { 76, 1, "/Catalog/090.jpg", "090", 93 },
                    { 50, 1, "/Catalog/064.jpg", "064", 67 },
                    { 51, 1, "/Catalog/065.jpg", "065", 68 },
                    { 24, 1, "/Catalog/035.jpg", "035", 35 },
                    { 22, 1, "/Catalog/033.jpg", "033", 33 },
                    { 21, 1, "/Catalog/031.jpg", "031", 31 },
                    { 20, 1, "/Catalog/027.jpg", "027", 27 },
                    { 19, 1, "/Catalog/923.png", "Pink Tone 923", 19 },
                    { 18, 1, "/Catalog/922.png", "Clear 922", 18 },
                    { 17, 1, "/Catalog/921.png", "Pink Opaque 921", 17 },
                    { 16, 1, "/Catalog/917.png", "Neon Pink 917", 16 },
                    { 15, 1, "/Catalog/916.png", "Neon Orange 916", 15 },
                    { 14, 1, "/Catalog/915.png", "Neon Green 915", 14 },
                    { 13, 1, "/Catalog/914.png", "Neon Yellow 914", 13 },
                    { 12, 1, "/Catalog/913.png", "Magenta 913", 12 },
                    { 11, 1, "/Catalog/912.png", "Black 912", 11 },
                    { 10, 1, "/Catalog/910.png", "Violet 910", 10 },
                    { 9, 1, "/Catalog/909.png", "White 909", 9 },
                    { 8, 1, "/Catalog/908.png", "Turquoise 908", 8 },
                    { 7, 1, "/Catalog/907.png", "Purple 907", 7 },
                    { 6, 1, "/Catalog/906.png", "Blue 906", 6 },
                    { 5, 1, "/Catalog/905.png", "Blue 905", 5 },
                    { 4, 1, "/Catalog/904.png", "Green 904", 4 },
                    { 3, 1, "/Catalog/903.png", "Blue 903", 3 },
                    { 2, 1, "/Catalog/902.png", "Yellow 902", 2 },
                    { 23, 1, "/Catalog/034.jpg", "034", 34 },
                    { 49, 1, "/Catalog/063.jpg", "063", 66 },
                    { 25, 1, "/Catalog/036.jpg", "036", 36 },
                    { 26, 1, "/Catalog/037.jpg", "037", 37 },
                    { 48, 1, "/Catalog/062.jpg", "062", 65 },
                    { 47, 1, "/Catalog/061.jpg", "061", 64 },
                    { 46, 1, "/Catalog/060.jpg", "060", 63 },
                    { 45, 1, "/Catalog/059.jpg", "059", 62 },
                    { 44, 1, "/Catalog/058.jpg", "058", 61 },
                    { 43, 1, "/Catalog/057.jpg", "057", 60 },
                    { 42, 1, "/Catalog/056.jpg", "056", 59 },
                    { 41, 1, "/Catalog/055.jpg", "055", 58 },
                    { 40, 1, "/Catalog/054.jpg", "054", 57 },
                    { 39, 1, "/Catalog/053.jpg", "053", 56 },
                    { 38, 1, "/Catalog/052.jpg", "052", 55 },
                    { 36, 1, "/Catalog/050.jpg", "050", 53 },
                    { 35, 1, "/Catalog/049.jpg", "049", 52 },
                    { 34, 1, "/Catalog/048.jpg", "048", 51 },
                    { 33, 1, "/Catalog/047.jpg", "047", 50 },
                    { 32, 1, "/Catalog/046.jpg", "046", 49 },
                    { 31, 1, "/Catalog/045.jpg", "045", 48 },
                    { 30, 1, "/Catalog/044.jpg", "044", 47 },
                    { 29, 1, "/Catalog/043.jpg", "043", 46 },
                    { 28, 1, "/Catalog/042.jpg", "042", 42 },
                    { 27, 1, "/Catalog/038.jpg", "038", 38 },
                    { 37, 1, "/Catalog/051.jpg", "051", 54 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 4, 10, 6, 22, 42, DateTimeKind.Local).AddTicks(6858), new DateTime(2021, 8, 4, 10, 6, 22, 42, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 4, 10, 6, 22, 43, DateTimeKind.Local).AddTicks(888), new DateTime(2021, 8, 4, 10, 6, 22, 43, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 4, 10, 6, 22, 43, DateTimeKind.Local).AddTicks(919), new DateTime(2021, 8, 4, 10, 6, 22, 43, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 4, 10, 6, 22, 43, DateTimeKind.Local).AddTicks(922), new DateTime(2021, 8, 4, 10, 6, 22, 43, DateTimeKind.Local).AddTicks(923) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblCatalog",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 3, 15, 32, 51, 876, DateTimeKind.Local).AddTicks(1126),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 8, 4, 10, 6, 22, 35, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(7896), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9833), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9842), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9846), new DateTime(2021, 8, 3, 15, 32, 51, 881, DateTimeKind.Local).AddTicks(9847) });
        }
    }
}
