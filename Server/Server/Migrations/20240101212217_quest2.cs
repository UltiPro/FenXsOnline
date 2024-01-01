using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class quest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroQuests_Heroes_HeroId",
                table: "HeroQuests");

            migrationBuilder.DropForeignKey(
                name: "FK_HeroQuests_Quests_QuestId",
                table: "HeroQuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroQuests",
                table: "HeroQuests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2ca8a2d-20fa-4134-830b-4b301e1e378b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3630b12-8a86-4c46-835d-91b507ceec2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5e6c6b2-efdb-4e41-9b3a-7f7276b7dfd3");

            migrationBuilder.RenameTable(
                name: "HeroQuests",
                newName: "HeroesQuests");

            migrationBuilder.RenameIndex(
                name: "IX_HeroQuests_QuestId",
                table: "HeroesQuests",
                newName: "IX_HeroesQuests_QuestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroesQuests",
                table: "HeroesQuests",
                columns: new[] { "HeroId", "QuestId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_HeroesQuests_Heroes_HeroId",
                table: "HeroesQuests",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroesQuests_Quests_QuestId",
                table: "HeroesQuests",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroesQuests_Heroes_HeroId",
                table: "HeroesQuests");

            migrationBuilder.DropForeignKey(
                name: "FK_HeroesQuests_Quests_QuestId",
                table: "HeroesQuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroesQuests",
                table: "HeroesQuests");

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

            migrationBuilder.RenameTable(
                name: "HeroesQuests",
                newName: "HeroQuests");

            migrationBuilder.RenameIndex(
                name: "IX_HeroesQuests_QuestId",
                table: "HeroQuests",
                newName: "IX_HeroQuests_QuestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroQuests",
                table: "HeroQuests",
                columns: new[] { "HeroId", "QuestId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2ca8a2d-20fa-4134-830b-4b301e1e378b", null, "Administrator", "ADMINISTRATOR" },
                    { "e3630b12-8a86-4c46-835d-91b507ceec2d", null, "Moderator", "MODERATOR" },
                    { "f5e6c6b2-efdb-4e41-9b3a-7f7276b7dfd3", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2024, 1, 1, 22, 20, 58, 877, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.AddForeignKey(
                name: "FK_HeroQuests_Heroes_HeroId",
                table: "HeroQuests",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeroQuests_Quests_QuestId",
                table: "HeroQuests",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
