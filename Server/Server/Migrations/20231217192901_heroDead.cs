using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class heroDead : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dead",
                table: "Heroes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e86f927-b30a-4ef2-aff6-d150515045c8", null, "Administrator", "ADMINISTRATOR" },
                    { "92e48b30-6cc7-4c1d-b8fb-ac8e0b7b7048", null, "User", "USER" },
                    { "cbbbd303-a82c-49f5-825a-52c27d79c8df", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 20, 29, 1, 76, DateTimeKind.Local).AddTicks(5537));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e86f927-b30a-4ef2-aff6-d150515045c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92e48b30-6cc7-4c1d-b8fb-ac8e0b7b7048");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbbbd303-a82c-49f5-825a-52c27d79c8df");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dead",
                table: "Heroes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "910228f2-3fa6-4fb9-9eda-66eaec58b7a7", null, "User", "USER" },
                    { "daaf9951-8fb1-4342-8294-af6e8d02930a", null, "Moderator", "MODERATOR" },
                    { "e5184717-6fca-41ea-b676-295c12df5fe9", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 17, 19, 33, 16, 213, DateTimeKind.Local).AddTicks(6339));

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
    }
}
