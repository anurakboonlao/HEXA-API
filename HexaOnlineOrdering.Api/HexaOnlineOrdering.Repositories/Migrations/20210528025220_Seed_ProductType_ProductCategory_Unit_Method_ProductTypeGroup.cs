using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_ProductType_ProductCategory_Unit_Method_ProductTypeGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Product" },
                    { 2, "Material" },
                    { 3, "Alloy" },
                    { 4, "Design" },
                    { 5, "Add-On" }
                });

            migrationBuilder.InsertData(
                table: "TblProductType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Crown & Bridge" },
                    { 2, "Removable" },
                    { 3, "Orthodontic" },
                    { 4, "Orthopedic" }
                });

            migrationBuilder.InsertData(
                table: "TblUnit",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unit A" },
                    { 2, "Unit B" }
                });

            migrationBuilder.InsertData(
                table: "TblMethod",
                columns: new[] { "Id", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, "Try in", 1 },
                    { 12, "Finish", 4 },
                    { 11, "Remake", 3 },
                    { 10, "Try in", 3 },
                    { 9, "Finish", 3 },
                    { 8, "Remake", 2 },
                    { 13, "Try in", 4 },
                    { 7, "Finish", 2 },
                    { 5, "Try in", 2 },
                    { 4, "Remake", 1 },
                    { 3, "Finish", 1 },
                    { 2, "Contour", 1 },
                    { 6, "Set up teeth", 2 },
                    { 14, "Remake", 4 }
                });

            migrationBuilder.InsertData(
                table: "TblProductTypeGroup",
                columns: new[] { "Id", "DisplayAsGroup", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 2, true, "Crown & Bridge 2", 1 },
                    { 3, true, "Removable 1", 2 },
                    { 4, true, "Removable 2", 2 },
                    { 1, true, "Crown & Bridge 1", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblMethod",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblProductCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblProductCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductTypeGroup",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblUnit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblUnit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblProductType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblProductType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblProductType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
