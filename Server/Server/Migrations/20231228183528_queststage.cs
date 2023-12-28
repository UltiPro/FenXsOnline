using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class queststage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63d50b6d-885d-43ec-a4b2-5a94257b7261");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c77a51d-937b-4bc5-becc-095085041c1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "818e6f5a-7438-45ad-8269-8ffbaf2e3d8a");

            migrationBuilder.CreateTable(
                name: "DBQuest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBQuest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestRewards",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestRewards", x => new { x.QuestId, x.ItemType, x.ItemId });
                    table.ForeignKey(
                        name: "FK_QuestRewards_DBQuest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "DBQuest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestStages",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Talk = table.Column<bool>(type: "bit", nullable: false),
                    NpcId = table.Column<int>(type: "int", nullable: true),
                    Wait = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NpcMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kill = table.Column<bool>(type: "bit", nullable: false),
                    MobId = table.Column<int>(type: "int", nullable: true),
                    Bring = table.Column<bool>(type: "bit", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Ammount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestStages", x => new { x.QuestId, x.Stage });
                    table.ForeignKey(
                        name: "FK_QuestStages_DBQuest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "DBQuest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestRewards");

            migrationBuilder.DropTable(
                name: "QuestStages");

            migrationBuilder.DropTable(
                name: "DBQuest");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63d50b6d-885d-43ec-a4b2-5a94257b7261", null, "User", "USER" },
                    { "7c77a51d-937b-4bc5-becc-095085041c1e", null, "Administrator", "ADMINISTRATOR" },
                    { "818e6f5a-7438-45ad-8269-8ffbaf2e3d8a", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 49 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 69 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 1, 2 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 20, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 43 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 50 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 39 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 86 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 46 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 51 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 66 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 83 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 91 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 89 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 40, 93 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 42, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 73 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 47, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 48, 88 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 51, 75 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 52, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 26 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 53, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 54, 92 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 13 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 55, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 57, 94 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 63 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 58, 67 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 27 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 53 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 58 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 61 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 59, 65 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 60 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 61, 62 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 62, 57 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 2, 21 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 4, 18 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 6, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 11 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 7, 17 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 8, 6 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 9, 20 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 13, 4 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 15, 25 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 16, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 5 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 17, 12 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 19, 8 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 7 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 22, 14 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 19 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 23, 24 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 10 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 24, 22 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "MapMobs",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 2, 27, 9 },
                column: "Available",
                value: new DateTime(2023, 12, 20, 0, 21, 41, 205, DateTimeKind.Local).AddTicks(4765));
        }
    }
}
