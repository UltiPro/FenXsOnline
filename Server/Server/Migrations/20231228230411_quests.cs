using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class quests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestRewards_DBQuest_QuestId",
                table: "QuestRewards");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestStages_DBQuest_QuestId",
                table: "QuestStages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DBQuest",
                table: "DBQuest");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e1fe7c4-5695-4e69-8f80-ae3124d4e3da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b9317b1-c7a1-4659-a472-c11533093b5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46ddf033-cf6f-423e-ae13-8268c0a17d1e");

            migrationBuilder.RenameTable(
                name: "DBQuest",
                newName: "Quests");

            migrationBuilder.RenameColumn(
                name: "Ammount",
                table: "QuestStages",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Quests",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Quests",
                newName: "NpcMessage");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "QuestRewards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NpcId",
                table: "Quests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quests",
                table: "Quests",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54a6c8b2-6961-449e-85b6-5e0ec97b3cef", null, "Administrator", "ADMINISTRATOR" },
                    { "634083cb-89cb-4d26-89fb-ea1952648d1e", null, "Moderator", "MODERATOR" },
                    { "7c4225c1-7853-49c6-a5b7-a4c7eb592e8c", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 29, 0, 4, 10, 614, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.InsertData(
                table: "Quests",
                columns: new[] { "Id", "Gold", "Level", "NpcId", "NpcMessage", "Title" },
                values: new object[,]
                {
                    { 1, 100, 1, 1, "I lost my necklace somewhere around here, could you find it and bring it back to me please?", "The healer's lost necklace" },
                    { 2, 300, 3, 2, "There are too many rabbits in the area, they are destroying crops, can you take care of it?", "Rabbit plague" },
                    { 3, 300, 5, 4, "There are too many spiders in the near cave, they are so scary, can you take care of it?", "Spider plague" },
                    { 4, 500, 7, 1, "I need 3 apples for a delicious apple cake, could you deliver them to me?", "Apple pie" },
                    { 5, 500, 9, 3, "I would like to examine mushrooms from a nearby cave, could you provide them to me?", "Mysterious mushrooms" }
                });

            migrationBuilder.InsertData(
                table: "QuestRewards",
                columns: new[] { "ItemId", "ItemType", "QuestId", "Quantity" },
                values: new object[,]
                {
                    { 1, 8, 1, 1 },
                    { 8, 9, 4, 1 },
                    { 10, 9, 5, 1 },
                    { 11, 9, 5, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_QuestRewards_Quests_QuestId",
                table: "QuestRewards",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestStages_Quests_QuestId",
                table: "QuestStages",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestRewards_Quests_QuestId",
                table: "QuestRewards");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestStages_Quests_QuestId",
                table: "QuestStages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quests",
                table: "Quests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54a6c8b2-6961-449e-85b6-5e0ec97b3cef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "634083cb-89cb-4d26-89fb-ea1952648d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4225c1-7853-49c6-a5b7-a4c7eb592e8c");

            migrationBuilder.DeleteData(
                table: "QuestRewards",
                keyColumns: new[] { "ItemId", "ItemType", "QuestId" },
                keyValues: new object[] { 1, 8, 1 });

            migrationBuilder.DeleteData(
                table: "QuestRewards",
                keyColumns: new[] { "ItemId", "ItemType", "QuestId" },
                keyValues: new object[] { 8, 9, 4 });

            migrationBuilder.DeleteData(
                table: "QuestRewards",
                keyColumns: new[] { "ItemId", "ItemType", "QuestId" },
                keyValues: new object[] { 10, 9, 5 });

            migrationBuilder.DeleteData(
                table: "QuestRewards",
                keyColumns: new[] { "ItemId", "ItemType", "QuestId" },
                keyValues: new object[] { 11, 9, 5 });

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "QuestRewards");

            migrationBuilder.DropColumn(
                name: "NpcId",
                table: "Quests");

            migrationBuilder.RenameTable(
                name: "Quests",
                newName: "DBQuest");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "QuestStages",
                newName: "Ammount");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "DBQuest",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NpcMessage",
                table: "DBQuest",
                newName: "Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DBQuest",
                table: "DBQuest",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e1fe7c4-5695-4e69-8f80-ae3124d4e3da", null, "Moderator", "MODERATOR" },
                    { "3b9317b1-c7a1-4659-a472-c11533093b5f", null, "User", "USER" },
                    { "46ddf033-cf6f-423e-ae13-8268c0a17d1e", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 20, 10, 38, 214, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.AddForeignKey(
                name: "FK_QuestRewards_DBQuest_QuestId",
                table: "QuestRewards",
                column: "QuestId",
                principalTable: "DBQuest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestStages_DBQuest_QuestId",
                table: "QuestStages",
                column: "QuestId",
                principalTable: "DBQuest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
