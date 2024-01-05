using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class quest7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12ae98b8-9af1-432b-a92f-7dc9dd69a336", null, "Administrator", "ADMINISTRATOR" },
                    { "254db02b-9e40-49d2-b8ae-b9a58e4b0769", null, "Moderator", "MODERATOR" },
                    { "fed46923-e0d2-4067-83ca-b37317bae92c", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 56, 71 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 5, 3, 20, 19, 545, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 1, 1 },
                column: "Talk",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 4, 1 },
                column: "Talk",
                value: true);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 5, 1 },
                column: "Talk",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12ae98b8-9af1-432b-a92f-7dc9dd69a336");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "254db02b-9e40-49d2-b8ae-b9a58e4b0769");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fed46923-e0d2-4067-83ca-b37317bae92c");

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

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 1, 1 },
                column: "Talk",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 4, 1 },
                column: "Talk",
                value: false);

            migrationBuilder.UpdateData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 5, 1 },
                column: "Talk",
                value: false);
        }
    }
}
