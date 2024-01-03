using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class quest4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "HeroesQuests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f913730-407a-4fb5-a01b-4e8c80bb35c4", null, "User", "USER" },
                    { "53a3fa4a-779a-4a3c-9795-dd3f1a0f0365", null, "Administrator", "ADMINISTRATOR" },
                    { "a4631f34-8d1c-49b1-b299-a9c7c1cc7f7e", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 3, 18, 39, 48, 83, DateTimeKind.Local).AddTicks(4800));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f913730-407a-4fb5-a01b-4e8c80bb35c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53a3fa4a-779a-4a3c-9795-dd3f1a0f0365");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4631f34-8d1c-49b1-b299-a9c7c1cc7f7e");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "HeroesQuests");

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
    }
}
