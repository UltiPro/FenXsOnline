using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class quest6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8778d543-7100-44da-b952-3fe77ca12c40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "896a22e8-ff27-4143-9f20-e7dca4eb644f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb55aef-26f1-4a02-a4a5-d81adb693265");

            migrationBuilder.DropColumn(
                name: "Bring",
                table: "QuestStages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b39f9f5-2173-4568-a405-15d276570184", null, "User", "USER" },
                    { "646c5c3e-a419-4759-9743-d64a7abac268", null, "Administrator", "ADMINISTRATOR" },
                    { "7faa5d12-0a2a-4063-94ef-c8c1dc33fdfa", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 56, 71 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 2, 14, 32, 738, DateTimeKind.Local).AddTicks(9385));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b39f9f5-2173-4568-a405-15d276570184");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "646c5c3e-a419-4759-9743-d64a7abac268");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7faa5d12-0a2a-4063-94ef-c8c1dc33fdfa");

            migrationBuilder.AddColumn<bool>(
                name: "Bring",
                table: "QuestStages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8778d543-7100-44da-b952-3fe77ca12c40", null, "User", "USER" },
                    { "896a22e8-ff27-4143-9f20-e7dca4eb644f", null, "Administrator", "ADMINISTRATOR" },
                    { "cbb55aef-26f1-4a02-a4a5-d81adb693265", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 56, 71 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 4, 20, 34, 34, 882, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 1, 1 },
                column: "Bring",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 2, 1 },
                column: "Bring",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 2, 2 },
                column: "Bring",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 3, 1 },
                column: "Bring",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 3, 2 },
                column: "Bring",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 4, 1 },
                column: "Bring",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 5, 1 },
                column: "Bring",
                value: true);
        }
    }
}
