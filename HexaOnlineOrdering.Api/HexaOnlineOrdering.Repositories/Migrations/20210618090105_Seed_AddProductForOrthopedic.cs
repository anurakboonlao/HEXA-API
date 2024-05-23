using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddProductForOrthopedic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblAddOn",
                columns: new[] { "Id", "Code", "ColorCode", "DisplayName", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 28, "OTA0001", "", "Solder/Welding ตำแหน่งละ", "", "Solder/Welding ตำแหน่งละ" },
                    { 42, "OTA0018", "", "Soldering Hook (Hook Included)", "", "Soldering Hook (Hook Included)" },
                    { 41, "OTA0011", "", "Band without Buccal Tube", "", "Band without Buccal Tube" },
                    { 40, "OTA0015", "", "Tripod ( 3 Points, Mounting Included)", "", "Tripod ( 3 Points, Mounting Included)" },
                    { 38, "OTA0012", "", "Band with Buccal Tube", "", "Band with Buccal Tube" },
                    { 37, "OTA0008", "", "Fan-Type Screw 2 pieces : 9 mm : A0815-14", "", "Fan-Type Screw 2 pieces : 9 mm : A0815-14" },
                    { 36, "OTA0010", "", "3D Screw-3 Activation Points", "", "3D Screw-3 Activation Points" },
                    { 39, "OTA0003", "", "เติม Bite Plane ตำแหน่งละ", "", "เติม Bite Plane ตำแหน่งละ" },
                    { 34, "OTA0007", "", "Sectional Screw, Stainless Steel:100/pcs No.600-500-60", "", "Sectional Screw, Stainless Steel:100/pcs No.600-500-60" },
                    { 33, "OTA0017", "", "Spinner", "", "Spinner" },
                    { 32, "OTA0004", "", "เติม Tongue Guard/Tongue Wire ตำแหน่งละ", "", "เติม Tongue Guard/Tongue Wire ตำแหน่งละ" },
                    { 31, "OTA0002", "", "เติม Spring หรือตะขอ ตำแหน่งละ", "", "เติม Spring หรือตะขอ ตำแหน่งละ" },
                    { 30, "OTA0014", "", "Occlusal Coverage / Bite Plane (Mounting Included)", "", "Occlusal Coverage / Bite Plane (Mounting Included)" },
                    { 29, "OTA0018", "", "Soldering Hook (Hook Included)", "", "Soldering Hook (Hook Included)" },
                    { 35, "OTA0009", "", "3D Screw - 2 Activation Points", "", "3D Screw - 2 Activation Points" }
                });

            migrationBuilder.InsertData(
                table: "TblMasterProduct",
                columns: new[] { "Id", "Code", "ColorCode", "ExpectedProductDay", "LogoPath", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 48, "OT0263", "", 3, "", "PMA appliance", 4 },
                    { 42, "OT0084", "", 3, "", "Power Arm (Soldering Service Included, Band not Included)", 4 },
                    { 43, "OT0085", "", 3, "", "Unilateral C.D. Distalizer (Premolar Bands, 0.9 NiTi Spring, Body Wire, Buccal Tubes and Soldering Service Included, Molar Band not Included)", 4 },
                    { 44, "OT0086", "", 3, "", "Bilateral C.D. Distalizer (Premolar Bands, 0.9 NiTi Springs, Body Wire, Buccal Tubes and Soldering Service Included, Molar Bands not Included)", 4 },
                    { 45, "OT0088", "", 3, "", "Class III Labial Bow (ไม่รวม Band)", 4 },
                    { 46, "OT0089", "", 3, "", "Pendulum (รวม Screw , ไม่รวม Band และ Lingual Sheath)", 4 },
                    { 47, "OT0220", "", 3, "", "Crozat", 4 },
                    { 49, "OT0264", "", 3, "", "PMA appliance ไม่รวม Band", 4 },
                    { 56, "OT0067", "", 3, "", "Trampoline 2 (2 Screws Included, Occlusal Coverage not Included)", 4 },
                    { 51, "OT0062", "", 3, "", "Semi-Fixed ALF with 3 Loops : Upper / Lower (Bands not Included)", 4 },
                    { 52, "OT0063", "", 3, "", "Semi-Fixed ALF with 5 Loops : Upper / Lower (Bands not Included)", 4 },
                    { 53, "OT0064", "", 3, "", "Removable ALF with 3 Loops : Upper / Lower", 4 },
                    { 54, "OT0065", "", 3, "", "Removable ALF with 5 Loops : Upper / Lower", 4 },
                    { 55, "OT0066", "", 3, "", "RN-Sagittal : Upper", 4 },
                    { 41, "OT0083", "", 3, "", "Uprighting Spring (Soldering Service Included, Band not Included)", 4 },
                    { 57, "OT0068", "", 3, "", "Semi-Fixed TPA Soldered with Gold (Spinner & Soldering Service Included)", 4 },
                    { 50, "OT0061", "", 3, "", "Class III Williams : Lower (Bands & Buttons not Included)", 4 },
                    { 40, "OT0082", "", 3, "", "Tongue Wire & Spinner (Bands not Included)", 4 },
                    { 33, "OT0077", "", 3, "", "Healing Splint : Upper / Lower (Soldering Hook not Included)", 4 },
                    { 38, "OT0080", "", 3, "", "Vinyl Splint : Upper / LowerOT0079 Pivotal Splint : Upper / Lower (Soldering Hook not Included)", 4 },
                    { 22, "OT0054", "", 3, "", "Schwarz Plate with 1 Screw", 4 },
                    { 23, "OT0055", "", 3, "", "Schwarz Plate with 2 Screws", 4 },
                    { 24, "OT0056", "", 3, "", "Schwarz Plate with 3 Screw", 4 },
                    { 25, "OT0057", "", 3, "", "Schwarz Plate with 3D Screws(2 Activation Points / 3 Activation Points)", 4 },
                    { 26, "OT0058", "", 3, "", "Schwarz Plate with Fan Gear", 4 },
                    { 27, "OT0059", "", 3, "", "Williams : Lower (Bands & Buttons not Included)", 4 },
                    { 28, "OT0072", "", 3, "", "Garcia Night-Time Retainer : Upper & Lower", 4 },
                    { 39, "OT0081", "", 3, "", "Anterior Deprogramming Appliance (ADA) : Upper / Lower", 4 },
                    { 29, "OT0078", "", 3, "", "Finishing Splint : Upper / Lower (Soldering Hook not Included)", 4 },
                    { 31, "OT0074", "", 3, "", "Bio-Retainer", 4 },
                    { 32, "OT0069", "", 3, "", "Corrector to Open, Corrector to Close, Corrector to Hold", 4 },
                    { 58, "OT0070", "", 3, "", "Twin Block Stage II : Upper", 4 },
                    { 34, "OT0071", "", 3, "", "Rick-A-Nator (Soldering Service Included, Bands & Lingual Sheath not Included)", 4 },
                    { 35, "OT0076", "", 3, "", "Truitt 3 (3D Screw , 4 Clasps, 1 Labial Bow, Occlusal Coverage Included, Soldering Service not Included)", 4 },
                    { 36, "OT0075", "", 3, "", "Frankel 3", 4 },
                    { 37, "OT0073", "", 3, "", "Tooth Setup with Spring Hawley Retainer ( Each Tooth)", 4 },
                    { 30, "OT0060", "", 3, "", "Maxillary Williams : Upper (Bands & Buttons not Included)", 4 }
                });

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "ProductTypeId" },
                values: new object[] { 3, false, "Orthopedic", 4 });

            migrationBuilder.InsertData(
                table: "TblProductAddOn",
                columns: new[] { "Id", "AddOnId", "InputType", "MasterProductId", "RequiredInput" },
                values: new object[,]
                {
                    { 46, 28, 5, 22, true },
                    { 80, 33, 5, 26, true },
                    { 81, 37, 5, 26, true },
                    { 82, 42, 5, 50, true },
                    { 83, 38, 5, 51, true },
                    { 84, 38, 5, 52, true },
                    { 85, 38, 5, 53, true },
                    { 86, 38, 5, 54, true },
                    { 87, 28, 6, 55, true },
                    { 89, 30, 6, 55, true },
                    { 90, 31, 6, 55, true },
                    { 91, 32, 6, 55, true },
                    { 92, 33, 6, 55, true },
                    { 93, 39, 6, 55, true },
                    { 94, 40, 6, 55, true },
                    { 95, 42, 6, 55, true },
                    { 96, 28, 6, 56, true },
                    { 98, 31, 6, 56, true },
                    { 99, 32, 6, 56, true },
                    { 100, 33, 6, 56, true },
                    { 101, 39, 6, 56, true },
                    { 102, 40, 6, 56, true },
                    { 103, 42, 6, 56, true },
                    { 104, 28, 5, 57, true },
                    { 105, 33, 5, 57, true },
                    { 106, 38, 5, 57, true },
                    { 107, 41, 5, 57, true },
                    { 108, 42, 5, 57, true },
                    { 109, 28, 5, 58, true },
                    { 110, 42, 5, 58, true },
                    { 79, 32, 5, 26, true },
                    { 78, 31, 5, 26, true },
                    { 97, 30, 6, 56, true },
                    { 76, 29, 5, 26, true },
                    { 77, 30, 5, 26, true },
                    { 47, 29, 5, 22, true },
                    { 48, 30, 5, 22, true },
                    { 49, 31, 5, 22, true },
                    { 50, 32, 5, 22, true },
                    { 51, 33, 5, 22, true },
                    { 52, 34, 5, 22, true },
                    { 53, 28, 5, 23, true },
                    { 55, 30, 5, 23, true },
                    { 56, 31, 5, 23, true },
                    { 57, 32, 5, 23, true },
                    { 58, 33, 5, 23, true },
                    { 59, 34, 5, 23, true },
                    { 60, 28, 5, 24, true },
                    { 54, 29, 5, 23, true },
                    { 62, 30, 5, 24, true },
                    { 75, 28, 5, 26, true },
                    { 61, 29, 5, 24, true },
                    { 74, 36, 5, 25, true },
                    { 73, 35, 5, 25, true },
                    { 72, 33, 5, 25, true },
                    { 71, 32, 5, 25, true },
                    { 69, 30, 5, 25, true },
                    { 70, 31, 5, 25, true },
                    { 67, 28, 5, 25, true },
                    { 66, 34, 5, 24, true },
                    { 65, 33, 5, 24, true },
                    { 64, 32, 5, 24, true },
                    { 63, 31, 5, 24, true },
                    { 68, 29, 5, 25, true }
                });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[,]
                {
                    { 43, 43, 3 },
                    { 47, 47, 3 },
                    { 44, 44, 3 },
                    { 42, 42, 3 },
                    { 45, 45, 3 },
                    { 46, 46, 3 },
                    { 48, 48, 3 },
                    { 55, 55, 3 },
                    { 50, 50, 3 },
                    { 51, 51, 3 },
                    { 52, 52, 3 },
                    { 53, 53, 3 },
                    { 54, 54, 3 },
                    { 41, 41, 3 },
                    { 56, 56, 3 },
                    { 49, 49, 3 },
                    { 40, 40, 3 },
                    { 24, 24, 3 },
                    { 38, 38, 3 },
                    { 57, 57, 3 },
                    { 22, 22, 3 },
                    { 23, 23, 3 },
                    { 25, 25, 3 },
                    { 26, 26, 3 },
                    { 27, 27, 3 },
                    { 28, 28, 3 },
                    { 39, 39, 3 },
                    { 29, 29, 3 },
                    { 31, 31, 3 },
                    { 32, 32, 3 },
                    { 33, 33, 3 },
                    { 34, 34, 3 },
                    { 35, 35, 3 },
                    { 36, 36, 3 },
                    { 37, 37, 3 },
                    { 30, 30, 3 },
                    { 58, 58, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 72);

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
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
