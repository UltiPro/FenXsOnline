using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class items : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16b6ec20-ed8a-42ff-8d8d-c46650c82393");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36231d7e-f87b-4cf1-8d79-c37424986cba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d51dea4-9b17-4bed-976e-83b33ad0f573");

            migrationBuilder.AddColumn<DateTime>(
                name: "Available",
                table: "MapMobs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "MapItems",
                columns: table => new
                {
                    MapId = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapItems", x => new { x.MapId, x.X, x.Y });
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "910228f2-3fa6-4fb9-9eda-66eaec58b7a7", null, "User", "USER" },
                    { "daaf9951-8fb1-4342-8294-af6e8d02930a", null, "Moderator", "MODERATOR" },
                    { "e5184717-6fca-41ea-b676-295c12df5fe9", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "MapItems",
                columns: new[] { "MapId", "X", "Y", "Available", "ItemId", "ItemType" },
                values: new object[,]
                {
                    { 1, 3, 49, new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6266), 10, 8 },
                    { 1, 15, 69, new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6264), 10, 8 },
                    { 1, 16, 94, new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6258), 10, 8 },
                    { 1, 55, 43, new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6268), 10, 8 },
                    { 2, 1, 2, new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6342), 12, 8 },
                    { 2, 20, 12, new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6339), 12, 8 }
                });

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6068));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "910228f2-3fa6-4fb9-9eda-66eaec58b7a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daaf9951-8fb1-4342-8294-af6e8d02930a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5184717-6fca-41ea-b676-295c12df5fe9");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "MapMobs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16b6ec20-ed8a-42ff-8d8d-c46650c82393", null, "User", "USER" },
                    { "36231d7e-f87b-4cf1-8d79-c37424986cba", null, "Administrator", "ADMINISTRATOR" },
                    { "8d51dea4-9b17-4bed-976e-83b33ad0f573", null, "Moderator", "MODERATOR" }
                });
        }
    }
}
