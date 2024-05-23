using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexaOnlineOrdering.Repositories.Migrations
{
    public partial class Seed_OrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblOrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Draft" },
                    { 2, "Waiting Order" },
                    { 3, "Ordered" },
                    { 5, "Delivery" },
                    { 6, "Completed" },
                    { 7, "Reject" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ContactId", "CreateAt", "LastUpdate", "Name" },
                values: new object[] { 32503, new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(2910), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(2959), "ทพญ.ศลิษา สิริยศธำรง" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ContactId", "CreateAt", "LastUpdate", "Name" },
                values: new object[] { 21379, new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(5995), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6003), "คลินิกบ้านหมอฟัน (พะเยา)" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6008), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6010), new DateTime(2021, 6, 22, 15, 0, 13, 92, DateTimeKind.Local).AddTicks(6011) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblOrderStatus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ContactId", "CreateAt", "LastUpdate", "Name" },
                values: new object[] { null, new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(2350), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(2390), "Chin Asuka" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ContactId", "CreateAt", "LastUpdate", "Name" },
                values: new object[] { null, new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4120), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130), "Ohmkoi Hospital" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateAt", "LastUpdate" },
                values: new object[] { new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4130), new DateTime(2021, 6, 21, 15, 55, 12, 930, DateTimeKind.Local).AddTicks(4140) });
        }
    }
}
