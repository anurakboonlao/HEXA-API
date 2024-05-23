using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class ChangeNameOfPlate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Labial Acrylic");

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Buccal Acrylic"); 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Labial Plate");

            migrationBuilder.UpdateData(
                table: "TblAddOn",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Buccal Plate");
        }
    }
}
