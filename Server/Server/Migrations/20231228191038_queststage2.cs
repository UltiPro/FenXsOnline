using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class queststage2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126a9bc7-ba33-4a2f-8497-d441fa0c5b40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fd6563c-1065-4159-9289-cffd7189f47a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9953334-2592-4022-ab64-82b6df5da388");

            migrationBuilder.DropColumn(
                name: "Wait",
                table: "QuestStages");

            migrationBuilder.AddColumn<string>(
                name: "NpcAnswear",
                table: "QuestStages",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "QuestStages",
                columns: new[] { "QuestId", "Stage", "Ammount", "Bring", "Description", "ItemId", "ItemType", "Kill", "MobId", "NpcAnswear", "NpcId", "NpcMessage", "Talk" },
                values: new object[,]
                {
                    { 1, 1, 1, true, "Find the healer's necklace and bring it to her.", 5, 10, false, null, "Thank you very much, here is your reward.", 1, "I found your necklace.", false },
                    { 2, 1, 30, false, "Kill 30 rabbits.", null, null, true, 1, null, null, null, false },
                    { 2, 2, null, false, "Tell Eldrik that you have killed enough rabbits.", null, null, false, null, "Thank you very much, here is your reward.", 2, "I killed rabbits.", true },
                    { 3, 1, 30, false, "Kill 30 spiders.", null, null, true, 2, null, null, null, false },
                    { 3, 2, null, false, "Tell Franko that you have killed enough spiders.", null, null, false, null, "Thank you very much, here is your reward.", 4, "I killed spiders.", true },
                    { 4, 1, 3, true, "Bring 3 apples for cake to Adelaide.", 10, 8, false, null, "Thank you very much, here is your reward.", 1, "I brought you three apples.", false },
                    { 5, 1, 5, true, "Bring 5 night mashroom to Gustaf.", 12, 8, false, null, "Thank you very much, here is your reward.", 3, "I brought you five night mashrooms.", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "QuestStages",
                keyColumns: new[] { "QuestId", "Stage" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DropColumn(
                name: "NpcAnswear",
                table: "QuestStages");

            migrationBuilder.AddColumn<DateTime>(
                name: "Wait",
                table: "QuestStages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "126a9bc7-ba33-4a2f-8497-d441fa0c5b40", null, "Moderator", "MODERATOR" },
                    { "1fd6563c-1065-4159-9289-cffd7189f47a", null, "User", "USER" },
                    { "b9953334-2592-4022-ab64-82b6df5da388", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 28, 19, 35, 28, 322, DateTimeKind.Local).AddTicks(9030));
        }
    }
}
