using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_IconCrownAndBridge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 15, 12, 7, 21, DateTimeKind.Local).AddTicks(2682),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 9, 57, 21, 387, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/OcclusalMetal.jpg");

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/3p4OcclusalMetal.jpg");

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/BuccalMetalMargin.jpg");

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/LingualMetalMargin.jpg");

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 5,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/NoMetalMargin.jpg");

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 6,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Design/PorcelainExtendedMargin.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 13,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/01Tooth.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 14,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/06Extraction.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 15,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/02Root.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 16,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/56FillingTop.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 17,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/27Veneer.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 18,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/29BridgeInstall.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 19,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/48EnamelDefence.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 20,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/14CrownInstall.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 21,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/Products/16ExtractingTooth.svg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 127,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/InlayOnlay/eMax.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 128,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/InlayOnlay/eMaxCad.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 129,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/InlayOnlay/EmpressCad.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 130,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/InlayOnlay/TetricCad.jpg");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 131,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/InlayOnlay/LisiPress.jpg");

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoPath",
                value: "/ProductIcon/CrownAndBridge/PFMMaterial/Argen.jpg");

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/ProductIcon/CrownAndBridge/PFMMaterial/Argen.jpg", "Palladium Silver for FMC" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg", "Palladium Yellow Color for FMC(Au 20%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg", "Palladium Base for Ceramic (PD 53.80%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg", "Semi Precious for Ceramic & FMC (Au 52.20%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/ProductIcon/CrownAndBridge/PFMMaterial/Cendres.jpg", "High Gold for FMC (Au 68.60%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { "/ProductIcon/CrownAndBridge/PFMMaterial/Cendres.jpg", "High White Gold for Ceramic & FMC (Au 76.80%)" });

            migrationBuilder.InsertData(
                table: "TblMaterial",
                columns: new[] { "Id", "LogoPath", "Name" },
                values: new object[,]
                {
                    { 10, "/ProductIcon/CrownAndBridge/PFMMaterial/Cendres.jpg", "High White Gold for Ceramic (Au 86.70%)" },
                    { 11, "/ProductIcon/CrownAndBridge/PFMMaterial/Ivoclar.jpg", "High Gold for FMC (Au 96.30%)" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(1043), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3758), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3767), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3770), new DateTime(2021, 6, 29, 15, 12, 7, 24, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.InsertData(
                table: "TblProductMaterial",
                columns: new[] { "Id", "MasterProductId", "MaterialId" },
                values: new object[,]
                {
                    { 17, 13, 10 },
                    { 19, 14, 10 },
                    { 18, 13, 11 },
                    { 20, 14, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblProductMaterial",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadedDate",
                table: "TblCaseAttachedFile",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 9, 57, 21, 387, DateTimeKind.Local).AddTicks(6917),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 6, 29, 15, 12, 7, 21, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 5,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblDesign",
                keyColumn: "Id",
                keyValue: 6,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 13,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 14,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 15,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 16,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 17,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 18,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 19,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 20,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 21,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 127,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 128,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 129,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 130,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMasterProduct",
                keyColumn: "Id",
                keyValue: 131,
                column: "LogoPath",
                value: "");

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { null, "Palladium" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { null, "Semi Precious" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { null, "High White Gold (Au 76.80%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { null, "High Yellow Gold For FMC (Au 68.60%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { null, "High Yellow Gold For FMC (Au 96.30%)" });

            migrationBuilder.UpdateData(
                table: "TblMaterial",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LogoPath", "Name" },
                values: new object[] { null, "High Yellow Gold For Ceramic (Au 86.70%)" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(4135), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7706), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7716), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7720), new DateTime(2021, 6, 29, 9, 57, 21, 392, DateTimeKind.Local).AddTicks(7722) });
        }
    }
}
