using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_ShadeSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 31, 17, 13, 14, 818, DateTimeKind.Local).AddTicks(2570),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 30, 16, 51, 4, 775, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.InsertData(
                table: "TblShadeSystem",
                columns: new[] { "Id", "Name", "Order", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, "VITA", 10, 1 },
                    { 2, "IVOCLAR A-D shade", 20, 1 },
                    { 3, "IVOCLAR CROMASCOP", 30, 1 },
                    { 4, "YAMAHASHI", 40, 2 },
                    { 5, "COSMO", 50, 2 },
                    { 6, "IVOCLAR CROMASCOP", 60, 2 },
                    { 7, "Majordent", 70, 2 },
                    { 8, "YAMAHACHI MONOPLANE (Flat AC)", 80, 2 },
                    { 9, "ORTHOLUX", 90, 2 },
                    { 10, "IVOCLAR A-D shade", 100, 2 },
                    { 11, "VITA", 110, 2 },
                    { 12, "LIVERA", 120, 2 }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 823, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 5, 31, 17, 13, 14, 823, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 5, 31, 17, 13, 14, 824, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.InsertData(
                table: "TblShade",
                columns: new[] { "Id", "Name", "Order", "ShadeSystemId" },
                values: new object[,]
                {
                    { 1, "1M1", 10, 1 },
                    { 127, "B2", 1270, 8 },
                    { 128, "B3", 1280, 8 },
                    { 129, "B4", 1290, 8 },
                    { 130, "C1", 1300, 8 },
                    { 131, "C2", 1310, 8 },
                    { 132, "C3", 1320, 8 },
                    { 133, "A1", 1330, 9 },
                    { 134, "A2", 1340, 9 },
                    { 135, "A3", 1350, 9 },
                    { 126, "B1", 1260, 8 },
                    { 136, "A3.5", 1360, 9 },
                    { 138, "B2", 1380, 9 },
                    { 139, "B4", 1390, 9 },
                    { 140, "C1", 1400, 9 },
                    { 141, "C2", 1410, 9 },
                    { 142, "D4", 1420, 9 },
                    { 143, "A1", 1430, 10 },
                    { 144, "A2", 1440, 10 },
                    { 145, "A3", 1450, 10 },
                    { 146, "A3.5", 1460, 10 },
                    { 137, "A4", 1370, 9 },
                    { 125, "A4", 1250, 8 },
                    { 124, "A3.5", 1240, 8 },
                    { 123, "A3", 1230, 8 },
                    { 102, "4B", 1020, 6 },
                    { 103, "6C", 1030, 6 },
                    { 104, "6D", 1040, 6 },
                    { 105, "4C", 1050, 6 },
                    { 106, "3C", 1060, 6 },
                    { 107, "4D", 1070, 6 },
                    { 108, "1D", 1080, 7 },
                    { 109, "1F", 1090, 7 },
                    { 110, "1R", 1100, 7 },
                    { 111, "2C", 1110, 7 },
                    { 112, "2L", 1120, 7 },
                    { 113, "3D", 1130, 7 },
                    { 114, "3F", 1140, 7 },
                    { 115, "3R", 1150, 7 },
                    { 116, "4C", 1160, 7 },
                    { 117, "4F", 1170, 7 },
                    { 118, "4L", 1180, 7 },
                    { 119, "5C", 1190, 7 },
                    { 120, "5D", 1200, 7 },
                    { 121, "A1", 1210, 8 },
                    { 122, "A2", 1220, 8 },
                    { 147, "A4", 1470, 10 },
                    { 148, "B1", 1480, 10 },
                    { 149, "B2", 1490, 10 },
                    { 150, "B3", 1500, 10 },
                    { 176, "A2", 1760, 11 },
                    { 177, "C2/D4", 1770, 11 },
                    { 178, "B3", 1780, 11 },
                    { 179, "A3/D3", 1790, 11 },
                    { 180, "A3.5", 1800, 11 },
                    { 181, "A4", 1810, 11 },
                    { 182, "C4", 1820, 11 },
                    { 183, "A1", 1830, 12 },
                    { 184, "A2", 1840, 12 },
                    { 185, "A3", 1850, 12 },
                    { 186, "A3.5", 1860, 12 },
                    { 187, "A4", 1870, 12 },
                    { 188, "B1", 1880, 12 },
                    { 189, "B2", 1890, 12 },
                    { 190, "B3", 1900, 12 },
                    { 191, "B4", 1910, 12 },
                    { 192, "C1", 1920, 12 },
                    { 193, "C2", 1930, 12 },
                    { 194, "C3", 1940, 12 },
                    { 195, "C4", 1950, 12 },
                    { 196, "D2", 1960, 12 },
                    { 175, "B2", 1750, 11 },
                    { 101, "6B", 1010, 6 },
                    { 174, "B1", 1740, 11 },
                    { 172, "C3", 1720, 11 },
                    { 151, "B4", 1510, 10 },
                    { 152, "C1", 1520, 10 },
                    { 153, "C2", 1530, 10 },
                    { 154, "C3", 1540, 10 },
                    { 155, "C4", 1550, 10 },
                    { 156, "D2", 1560, 10 },
                    { 157, "D3", 1570, 10 },
                    { 158, "D4", 1580, 10 },
                    { 159, "1M1", 1590, 11 },
                    { 160, "2L1.5", 1600, 11 },
                    { 161, "2M1", 1610, 11 },
                    { 162, "2M2", 1620, 11 },
                    { 163, "3L1.5", 1630, 11 },
                    { 164, "3L2.5", 1640, 11 },
                    { 165, "3M2", 1650, 11 },
                    { 166, "3R2.5", 1660, 11 },
                    { 167, "4L.15", 1670, 11 },
                    { 168, "4M2", 1680, 11 },
                    { 169, "5M1", 1690, 11 },
                    { 170, "A1", 1700, 11 },
                    { 171, "A3", 1710, 11 },
                    { 173, "D3", 1730, 11 },
                    { 100, "4A", 1000, 6 },
                    { 99, "3E", 990, 6 },
                    { 98, "2E", 98, 6 },
                    { 27, "A3", 270, 2 },
                    { 28, "A3.5", 280, 2 },
                    { 29, "A4", 290, 2 },
                    { 30, "B1", 300, 2 },
                    { 31, "B2", 310, 2 },
                    { 32, "B3", 320, 2 },
                    { 33, "B3", 330, 2 },
                    { 34, "B4", 340, 2 },
                    { 35, "C1", 350, 2 },
                    { 36, "C2", 360, 2 },
                    { 37, "C3", 370, 2 },
                    { 38, "C4", 380, 2 },
                    { 39, "D2", 390, 2 },
                    { 40, "D3", 400, 2 },
                    { 41, "D4", 410, 2 },
                    { 42, "01", 420, 3 },
                    { 43, "1A", 430, 3 },
                    { 44, "2A", 440, 3 },
                    { 45, "1C", 450, 3 },
                    { 46, "2B", 460, 3 },
                    { 47, "1D", 470, 3 },
                    { 26, "A2", 260, 2 },
                    { 48, "1E", 480, 3 },
                    { 25, "A1", 250, 2 },
                    { 23, "A4", 230, 1 },
                    { 2, "2L1.5", 20, 1 },
                    { 3, "2M1", 30, 1 },
                    { 4, "2M2", 40, 1 },
                    { 5, "3L1.5", 50, 1 },
                    { 6, "3L2.5", 60, 1 },
                    { 7, "3M2", 70, 1 },
                    { 8, "3R2.5", 80, 1 },
                    { 9, "4L1.5", 90, 1 },
                    { 10, "4M2", 100, 1 },
                    { 11, "5M1", 110, 1 },
                    { 12, "A1", 120, 1 },
                    { 13, "A3", 130, 1 },
                    { 14, "C3", 140, 1 },
                    { 15, "D3", 150, 1 },
                    { 16, "B1", 160, 1 },
                    { 17, "B2", 170, 1 },
                    { 18, "A2", 180, 1 },
                    { 19, "C2/D4", 190, 1 },
                    { 20, "B3", 200, 1 },
                    { 21, "A3/D3", 210, 1 },
                    { 22, "A3.5", 220, 1 },
                    { 24, "C4", 240, 1 },
                    { 197, "D3", 1970, 12 },
                    { 49, "2C", 490, 3 },
                    { 51, "5B", 510, 3 },
                    { 77, "A3.5", 770, 5 },
                    { 78, "A4", 780, 5 },
                    { 79, "B2", 790, 5 },
                    { 80, "B3", 800, 5 },
                    { 81, "B4", 810, 5 },
                    { 82, "C2", 820, 5 },
                    { 83, "C3", 830, 5 },
                    { 84, "C4", 840, 5 },
                    { 85, "D2", 850, 5 },
                    { 86, "D3", 860, 5 },
                    { 87, "D4", 870, 5 },
                    { 88, "01", 880, 6 },
                    { 89, "1A", 890, 6 },
                    { 90, "2A", 900, 6 },
                    { 91, "1C", 910, 6 },
                    { 92, "2B", 920, 6 },
                    { 93, "1D", 930, 6 },
                    { 94, "1E", 940, 6 },
                    { 95, "2C", 950, 6 },
                    { 96, "3A", 960, 6 },
                    { 97, "5B", 970, 6 },
                    { 76, "A3", 760, 5 },
                    { 50, "3A", 500, 3 },
                    { 75, "A2", 750, 5 },
                    { 73, "C3", 730, 4 },
                    { 52, "2E", 520, 3 },
                    { 53, "3E", 530, 3 },
                    { 54, "4A", 540, 3 },
                    { 55, "6B", 550, 3 },
                    { 56, "4B", 560, 3 },
                    { 57, "6C", 570, 3 },
                    { 58, "6D", 580, 3 },
                    { 59, "4C", 590, 3 },
                    { 60, "3C", 600, 3 },
                    { 61, "4D", 610, 3 },
                    { 62, "A1", 620, 4 },
                    { 63, "A2", 630, 4 },
                    { 64, "A3", 640, 4 },
                    { 65, "A3.5", 650, 4 },
                    { 66, "A4", 660, 4 },
                    { 67, "B1", 670, 4 },
                    { 68, "B2", 680, 4 },
                    { 69, "B3", 690, 4 },
                    { 70, "B4", 700, 4 },
                    { 71, "C1", 710, 4 },
                    { 72, "C2", 720, 4 },
                    { 74, "A1", 740, 5 },
                    { 198, "D4", 1980, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TblShade",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblShadeSystem",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 16, 51, 4, 775, DateTimeKind.Local).AddTicks(3740),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 5, 31, 17, 13, 14, 818, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 780, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 5, 30, 16, 51, 4, 780, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2300), new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 5, 30, 16, 51, 4, 781, DateTimeKind.Local).AddTicks(2750) });
        }
    }
}
