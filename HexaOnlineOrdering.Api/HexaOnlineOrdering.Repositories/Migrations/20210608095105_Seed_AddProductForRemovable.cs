using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_AddProductForRemovable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblAddOn",
                columns: new[] { "Id", "Code", "ColorCode", "DisplayName", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 1, "REA0001", "", "TP ซี่ต่อไป (ซี่ละ)", "", "TP ซี่ต่อไป (ซี่ละ)" },
                    { 27, "REA0077", "", "Rest (ลวดดัด)", "", "Rest (ลวดดัด)" },
                    { 26, "REA0045", "", "High Impact for RPD (คิดเพิ่ม)", "", "High Impact for RPD (คิดเพิ่ม)" },
                    { 25, "REA0041", "", "Acetal Clasp ตะขอสีเหมือนฟัน (ตะขอละ)", "", "Acetal Clasp ตะขอสีเหมือนฟัน (ตะขอละ)" },
                    { 24, "REA0039", "", "Swing Lock in Acetal,Valplast,Metal", "", "Swing Lock in Acetal,Valplast,Metal" },
                    { 22, "REA0037", "", "ตะขอเหวี่ยงโลหะ", "", "ตะขอเหวี่ยงโลหะ" },
                    { 21, "REA0035", "", "Rest (เหวี่ยงโลหะ)", "", "Rest (เหวี่ยงโลหะ)" },
                    { 20, "REA0033", "", "Backing (คิดเพิ่มซี่ละ)", "", "Backing (คิดเพิ่มซี่ละ)" },
                    { 19, "REA0032", "", "Full Metal Tooth (คิดเพิ่มซี่ละ)", "", "Full Metal Tooth (คิดเพิ่มซี่ละ)" },
                    { 18, "REA0031", "", "ฟัน Acetal บนโครง RPD (ซี่ละ)", "", "ฟัน Acetal บนโครง RPD (ซี่ละ)" },
                    { 17, "REA0029", "", "Clear Acrylic", "", "Clear Acrylic" },
                    { 16, "REA0028", "", "Overlay Denture (ซี่ละ)", "", "Overlay Denture (ซี่ละ)" },
                    { 15, "REA0027", "", "Acrylic Gum slip (ต่อชิ้น)", "", "Acrylic Gum slip (ต่อชิ้น)" },
                    { 23, "REA0038", "", "ตะแกรง (เหวี่ยงโลหะ)", "", "ตะแกรง (เหวี่ยงโลหะ)" },
                    { 13, "REA0022", "", "High Impact for Full Denture (คิดเพิ่ม)", "", "High Impact for Full Denture (คิดเพิ่ม)" },
                    { 12, "REA0021", "", "ตะแกรงทองใหญ่ (สำเร็จ)", "", "ตะแกรงทองใหญ่ (สำเร็จ)" },
                    { 11, "REA0020", "", "ตะแกรงทองเล็ก (สำเร็จ)", "", "ตะแกรงทองเล็ก (สำเร็จ)" },
                    { 10, "REA0018", "", "เติมฐานนิ่มบางตำแหน่ง (ตำแหน่งละ) (Vertex)", "", "เติมฐานนิ่มบางตำแหน่ง (ตำแหน่งละ) (Vertex)" },
                    { 9, "REA0013", "", "เสริมโลหะเหวี่ยงงาน TP ( Casting Lingual Bar)", "", "เสริมโลหะเหวี่ยงงาน TP ( Casting Lingual Bar)" },
                    { 8, "REA0011", "", "เสริมลวดงาน TP (ดามลวด)", "", "เสริมลวดงาน TP (ดามลวด)" },
                    { 7, "REA0010", "", "Twinflex in TP", "", "Twinflex in TP" },
                    { 6, "REA0009", "", "ตะขอ Y or T", "", "ตะขอ Y or T" },
                    { 5, "REA0008", "", "ตะขอ Ball / Adam", "", "ตะขอ Ball / Adam" },
                    { 4, "REA0006", "", "ตะขอลวดดัด", "", "ตะขอลวดดัด" },
                    { 3, "REA0005", "", "Valplast Clasp", "", "Valplast Clasp" },
                    { 2, "REA0002", "", "งานฐานนิ่ม (Softbase vertex)", "", "งานฐานนิ่ม (Softbase vertex)" },
                    { 14, "REA0023", "", "High Impact for TP (คิดเพิ่ม)", "", "High Impact for TP (คิดเพิ่ม)" }
                });

            migrationBuilder.InsertData(
                table: "TblCaseStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Draft" },
                    { 2, "Ordered" }
                });

            migrationBuilder.InsertData(
                table: "TblCaseType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Warranty" },
                    { 1, "New Case" },
                    { 2, "Remake" }
                });

            migrationBuilder.InsertData(
                table: "TblMasterProduct",
                columns: new[] { "Id", "ColorCode", "ExpectedProductDay", "LogoPath", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, "#3bb858", 3, "", "Full Denture", 2 },
                    { 2, "#968226", 3, "", "Partial Denture Framework", 2 },
                    { 3, "#604bbf", 3, "", "Temporary Partial Plate", 2 },
                    { 4, "", 3, "", "Bite Block", 2 },
                    { 5, "", 3, "", "Chrome Cobalt Retaner", 2 },
                    { 6, "", 3, "", "Flexible Denture", 2 },
                    { 7, "", 3, "", "Special Tray", 2 },
                    { 8, "", 3, "", "Peek (Polyetheretherketone)", 2 },
                    { 9, "", 3, "", "Peek for RPD (เฉพาะโครง)", 2 },
                    { 10, "", 3, "", "Peek for RB (เฉพาะโครง)", 2 },
                    { 11, "", 3, "", "Acetal Plate", 2 },
                    { 12, "", 3, "", "RB All Acetal", 2 }
                });

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, false, "Crown & Bridge", 1 },
                    { 2, false, "Removable", 2 }
                });

            migrationBuilder.InsertData(
                table: "TblProductAddOn",
                columns: new[] { "Id", "AddOnId", "InputType", "MasterProductId", "RequiredInput" },
                values: new object[,]
                {
                    { 1, 2, 3, 1, true },
                    { 26, 8, null, 3, false },
                    { 27, 11, null, 3, false },
                    { 28, 12, null, 3, false },
                    { 30, 20, 1, 3, true },
                    { 31, 5, 1, 3, true },
                    { 32, 7, 1, 3, true },
                    { 33, 9, 1, 3, true },
                    { 34, 14, null, 3, false },
                    { 35, 15, null, 3, false },
                    { 36, 16, 1, 3, true },
                    { 37, 17, null, 3, false },
                    { 38, 21, null, 3, false },
                    { 39, 22, 1, 3, true },
                    { 40, 27, 1, 3, true },
                    { 41, 4, 1, 4, true },
                    { 42, 6, 1, 4, true },
                    { 43, 27, 1, 4, true },
                    { 44, 1, 1, 5, true },
                    { 45, 2, 1, 5, true },
                    { 25, 25, 1, 3, true },
                    { 24, 6, 1, 3, true },
                    { 29, 23, null, 3, false },
                    { 22, 26, null, 2, false },
                    { 2, 3, 1, 1, true },
                    { 3, 4, 1, 1, true },
                    { 4, 6, 1, 1, true },
                    { 5, 10, 2, 1, true },
                    { 6, 25, 1, 1, true },
                    { 23, 4, 1, 3, true },
                    { 8, 11, null, 1, false },
                    { 9, 12, null, 1, false },
                    { 10, 13, null, 1, false },
                    { 11, 23, null, 1, false },
                    { 7, 8, null, 1, false },
                    { 13, 3, 1, 2, true },
                    { 14, 4, 1, 2, true },
                    { 15, 6, 1, 2, true },
                    { 16, 10, 2, 2, true },
                    { 17, 18, 1, 2, true },
                    { 18, 19, 1, 2, true },
                    { 19, 20, 1, 2, true },
                    { 20, 24, null, 2, false },
                    { 21, 25, 1, 2, true },
                    { 12, 2, null, 2, false }
                });

            migrationBuilder.InsertData(
                table: "TblProductGroupItem",
                columns: new[] { "Id", "ProductId", "ProductTypeGroupId" },
                values: new object[,]
                {
                    { 10, 10, 2 },
                    { 9, 9, 2 },
                    { 8, 8, 2 },
                    { 7, 7, 2 },
                    { 6, 6, 2 },
                    { 1, 1, 2 },
                    { 4, 4, 2 },
                    { 3, 3, 2 },
                    { 2, 2, 2 },
                    { 11, 11, 2 },
                    { 5, 5, 2 },
                    { 12, 12, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblCaseStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblCaseStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblCaseType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblCaseType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblCaseType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblProductAddOn",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblProductGroupItem",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
