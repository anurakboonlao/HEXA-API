using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddProductForOrthodontic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblAddOn",
                columns: new[] { "Id", "Code", "ColorCode", "DisplayName", "LogoPath", "Name" },
                values: new object[] { 43, "OTA0004 ", "", "เติม Tongue Guard/Tongue Wire ตำแหน่งละ", "", "เติม Tongue Guard/Tongue Wire ตำแหน่งละ" });

            migrationBuilder.InsertData(
                table: "TblMasterProduct",
                columns: new[] { "Id", "Code", "ColorCode", "ExpectedProductDay", "LogoPath", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 94, "OT0039", "", 3, "", "Set Up Tooth (per tooth)", 3 },
                    { 96, "OT0042", "", 3, "", " Hexa Lingual Individual Bracket Placement (ต่อซี่น)", 3 },
                    { 97, "OT0043", "", 3, "", "Labial Indirect Matrix Bonding (Upper or Lower)(ไม่รวม Bracket)", 3 },
                    { 98, "OT0052", "", 3, "", "Anterior Bite Plane (รวมตะขอ) number of ball", 3 },
                    { 99, "OT0053", "", 3, "", "Posterior Bite Plane (รวมตะขอ)", 3 },
                    { 100, "OT0017", "", 3, "", "Band and Loop (ไม่รวม Band)", 3 },
                    { 101, "OT0018", "", 3, "", "Distal Shoe (ไม่รวม Band)", 3 },
                    { 102, "OT0019", "", 3, "", "Trans Palatal Bar or TPA (Not included Band)", 3 },
                    { 103, "OT0020", "", 3, "", "Mandibular Lingual Holding Arch (ไม่รวม Band)", 3 },
                    { 104, "OT0021", "", 3, "", "Nance:Upper (Soldering Service Included,Not included Band)", 3 },
                    { 105, "OT0022", "", 3, "", "Tongue Clip", 3 },
                    { 106, "OT0232", "", 3, "", "TPA and Nance (soldering Service Included, Band Not Included)", 3 },
                    { 107, "OT0014", "", 3, "", "Occlusal Splint (Hard)", 3 },
                    { 108, "OT0016", "", 3, "", "Stent for Implant (Self Cure)", 3 },
                    { 109, "OT0023", "", 3, "", "Garger Splint (Inside soft/Outside hard)", 3 },
                    { 110, "OT0178", "", 3, "", "Damon Splint ( 2 template 1mm )", 3 },
                    { 111, "OT0305", "", 3, "", "3D Printed Surgical Splint", 3 },
                    { 125, "OT0343", "", 3, "", "Night Guard Hard/Soft", 3 },
                    { 124, "OT0268", "", 3, "", "3D Printed Nasal Form", 3 },
                    { 123, "OT0183", "", 3, "", "Night Guard (soft) 4 mm.", 3 },
                    { 122, "OT0051", "", 3, "", "Bleaching Tray (ไม่รวม sheet)", 3 },
                    { 121, "OT0050", "", 3, "", "Bleaching Tray (รวม sheet)", 3 },
                    { 120, "OT0049", "", 3, "", "Mouth Guard 6 MM ( Clear/color)", 3 },
                    { 93, "OT0027", "", 3, "", "Clear Aligner", 3 },
                    { 119, "OT0048", "", 3, "", "Mouth Guard 5 MM ( Clear/color)", 3 },
                    { 117, "OT0046", "", 3, "", "Mouth Guard 3 MM ( Clear/Color)", 3 },
                    { 116, "OT0045", "", 3, "", "Night Guard (Hard)", 3 },
                    { 115, "OT0044", "", 3, "", "Night Guard (Soft)", 3 },
                    { 114, "OT0015", "", 3, "", "Clape Palate (Obtulator Palate)", 3 },
                    { 113, "OT0321", "", 3, "", "Stent for Implant (Vacum Plate)", 3 },
                    { 112, "OT0310", "", 3, "", "Milled Occlusal Splint", 3 },
                    { 118, "OT0047", "", 3, "", "Mouth Guard 4 MM ( Clear)", 3 },
                    { 92, "OT0013", "", 3, "", "Lip Bumper Appliance", 3 },
                    { 95, "OT0040", "", 3, "", "Set Up Model (ต่อชิ้น)", 3 },
                    { 90, "OT0011", "", 3, "", "Quad Helix", 3 },
                    { 72, "OT0036", "", 3, "", "Printed Resin 3D Study Model (ต่อคู่)", 3 },
                    { 91, "OT0012", "", 3, "", "Hyrax Expansion Screw", 3 },
                    { 70, "OT0034", "", 3, "", "Working Model / Sending Impression (per set)", 3 },
                    { 69, "OT0033", "", 3, "", "Study Model not polished per set", 3 },
                    { 68, "OT0032", "", 3, "", "Study Model (American Polished) per set", 3 },
                    { 67, "OT0026", "", 3, "", "Printed Resin 3D Study Model (per set)", 3 },
                    { 73, "OT0037", "", 3, "", "ต่อฐำน แช่น้ำสบู่ (ต่อชิ้น)", 3 },
                    { 66, "OT0025", "", 3, "", "Ortho model upper and lower", 3 },
                    { 64, "OT0030", "", 3, "", "Twin Block Upper or Lower (ไม่รวม Screw)", 3 },
                    { 63, "OT0029", "", 3, "", "Bionater to Open,to Close,to Hold", 3 },
                    { 62, "OT0028", "", 3, "", "Activator", 3 },
                    { 61, "OT0267", "", 3, "", "TAP T (Anti-Snoring) Include screw", 3 },
                    { 60, "OT0097", "", 3, "", "IST Appliance (Herbst)", 3 },
                    { 59, "OT0031", "", 3, "", "M.D.S.A (Anti Snoring Appliance)", 3 },
                    { 65, "OT0024", "", 3, "", "Ortho model upper or lower", 3 },
                    { 74, "OT0038", "", 3, "", "ต่อฐำน ไม่แช่น้ำสบู่ (ต่อชิ้น)", 3 },
                    { 71, "OT0035", "", 3, "", "Study Model Scan 3D Digital File (ต่อคู่)", 3 },
                    { 76, "OT0240", "", 3, "", "Duplicate Model (ชิ้น)", 3 },
                    { 89, "OT0010", "", 3, "", "Removable with Screw (ไม่รวม Screw)", 3 },
                    { 88, "OT0009", "", 3, "", "Removable with Screw", 3 },
                    { 75, "OT0041", "", 3, "", "Duplicate Model(ต่อคู่)", 3 },
                    { 86, "", "", 3, "", "Chrome Cobalt Retainer", 3 },
                    { 85, "OT0007", "", 3, "", "C-C Retainer", 3 },
                    { 84, "OT0006", "", 3, "", "Advance Functional Retainer", 3 },
                    { 87, "OT0008", "", 3, "", "Removable with Any Springs", 3 },
                    { 82, "OT0004", "", 3, "", "Clear Blow (Included Acrylic Plate)", 3 },
                    { 81, "OT0003", "", 3, "", "Clear Retainer", 3 },
                    { 80, "OT0002", "", 3, "", "Wrap Around Retainer", 3 },
                    { 79, "OT0001", "", 3, "", "Hawley's Retainer", 3 },
                    { 78, "OT0301", "", 3, "", "Model only (Ortho model upper + lower)", 3 },
                    { 77, "OT0300", "", 3, "", "Model only (Ortho model upper or lower)", 3 },
                    { 83, "OT0005", "", 3, "", "Spring Hawley Retainer", 3 }
                });

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 10, true, "Splint / Stent", 3 },
                    { 4, true, "Anti Snoring", 3 },
                    { 5, true, "Functional", 3 },
                    { 6, true, "Model", 3 },
                    { 7, true, "Retainer", 3 },
                    { 8, true, "Passive / Active Plate", 3 },
                    { 9, true, "Space Mantainer", 3 },
                    { 11, true, "Orther", 3 }
                });

            migrationBuilder.InsertData(
                table: "TblProductAddOn",
                columns: new[] { "Id", "AddOnId", "InputType", "MasterProductId", "RequiredInput" },
                values: new object[,]
                {
                    { 111, 34, 4, 62, true },
                    { 131, 36, 6, 88, true },
                    { 132, 28, 5, 90, true },
                    { 133, 42, 5, 90, true },
                    { 134, 41, 5, 90, true },
                    { 135, 38, 5, 90, true },
                    { 136, 28, 5, 91, true },
                    { 130, 35, 6, 88, true },
                    { 137, 42, 5, 91, true },
                    { 139, 38, 5, 91, true },
                    { 140, 30, 5, 91, true },
                    { 141, 28, 5, 92, true },
                    { 142, 42, 5, 92, true },
                    { 143, 41, 5, 92, true },
                    { 145, 30, 5, 92, true },
                    { 138, 41, 5, 91, true },
                    { 129, 37, 6, 88, true },
                    { 144, 38, 5, 92, true },
                    { 127, 33, 6, 88, true },
                    { 112, 34, 4, 63, true },
                    { 113, 34, 4, 64, true },
                    { 114, 28, 6, 87, true },
                    { 115, 31, 6, 87, true },
                    { 128, 34, 6, 88, true },
                    { 117, 32, 6, 87, true },
                    { 118, 42, 6, 87, true },
                    { 116, 39, 6, 87, true },
                    { 120, 33, 6, 87, true },
                    { 121, 28, 6, 88, true },
                    { 122, 31, 6, 88, true },
                    { 123, 39, 6, 88, true },
                    { 124, 32, 6, 88, true },
                    { 125, 42, 6, 88, true },
                    { 126, 30, 6, 88, true },
                    { 119, 30, 6, 87, true }
                });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[,]
                {
                    { 106, 106, 9 },
                    { 105, 105, 9 },
                    { 104, 104, 9 },
                    { 103, 103, 9 },
                    { 102, 102, 9 },
                    { 101, 101, 9 },
                    { 94, 94, 8 },
                    { 99, 99, 8 },
                    { 98, 98, 8 },
                    { 97, 97, 8 },
                    { 96, 96, 8 },
                    { 95, 95, 8 },
                    { 107, 107, 10 },
                    { 100, 100, 9 },
                    { 108, 108, 10 },
                    { 116, 116, 11 },
                    { 110, 110, 10 },
                    { 111, 111, 10 },
                    { 112, 112, 10 },
                    { 113, 113, 10 },
                    { 114, 114, 11 },
                    { 115, 115, 11 },
                    { 117, 117, 11 },
                    { 118, 118, 11 },
                    { 119, 119, 11 },
                    { 120, 120, 11 },
                    { 121, 121, 11 },
                    { 122, 122, 11 },
                    { 123, 123, 11 },
                    { 93, 93, 8 },
                    { 109, 109, 10 },
                    { 92, 92, 8 },
                    { 74, 74, 6 },
                    { 90, 90, 8 },
                    { 59, 59, 4 },
                    { 60, 60, 4 },
                    { 61, 61, 4 },
                    { 62, 62, 5 },
                    { 63, 63, 5 },
                    { 64, 64, 5 },
                    { 65, 65, 6 },
                    { 66, 66, 6 },
                    { 67, 67, 6 },
                    { 68, 68, 6 },
                    { 69, 69, 6 },
                    { 70, 70, 6 },
                    { 71, 71, 6 },
                    { 72, 72, 6 },
                    { 73, 73, 6 },
                    { 124, 124, 11 },
                    { 75, 75, 6 },
                    { 89, 89, 8 },
                    { 88, 88, 8 },
                    { 87, 87, 8 },
                    { 86, 86, 7 },
                    { 85, 85, 7 },
                    { 84, 84, 7 },
                    { 91, 91, 8 },
                    { 83, 83, 7 },
                    { 81, 81, 7 },
                    { 80, 80, 7 },
                    { 79, 79, 7 },
                    { 78, 78, 6 },
                    { 77, 77, 6 },
                    { 76, 76, 6 },
                    { 82, 82, 7 },
                    { 125, 125, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
