using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class quest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c493ea8-b302-4f9d-abc2-21a773e17003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a467ca67-49bd-4309-ab6e-f1b1c3dfba28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff24491f-a658-4a16-aba1-c3bded2cd964");

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "HeroesQuests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "283776f0-0cdb-408c-b22e-32ec228414f1", null, "Moderator", "MODERATOR" },
                    { "561498a6-3e91-41fa-ad39-61ef87d3ca8b", null, "Administrator", "ADMINISTRATOR" },
                    { "711a8290-9e5a-4918-aaf2-f032c322256a", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 15, 23, 21, 706, DateTimeKind.Local).AddTicks(8106));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "283776f0-0cdb-408c-b22e-32ec228414f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "561498a6-3e91-41fa-ad39-61ef87d3ca8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "711a8290-9e5a-4918-aaf2-f032c322256a");

            migrationBuilder.DropColumn(
                name: "Stage",
                table: "HeroesQuests");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c493ea8-b302-4f9d-abc2-21a773e17003", null, "Moderator", "MODERATOR" },
                    { "a467ca67-49bd-4309-ab6e-f1b1c3dfba28", null, "User", "USER" },
                    { "ff24491f-a658-4a16-aba1-c3bded2cd964", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 22, 17, 362, DateTimeKind.Local).AddTicks(8087));
        }
    }
}
