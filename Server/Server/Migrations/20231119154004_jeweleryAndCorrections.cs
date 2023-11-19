using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class jeweleryAndCorrections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2944c11c-e25f-41d9-a0d6-79186f0f7d40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "587f6133-2a8f-473b-bada-05469403befa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "661fedf3-2fdb-4361-9c32-3e0b1e91bd97");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "SecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Rings");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Necklaces");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Helmets");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Gloves");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Boots");

            migrationBuilder.DropColumn(
                name: "QuestItem",
                table: "Armors");

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Professions",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "SecondaryWeapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Professions",
                table: "SecondaryWeapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Rings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Necklaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Helmets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Gloves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Boots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Armors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "957094e7-c8b0-48bb-8c20-01c0f2b5aa20", null, "User", "USER" },
                    { "cecd7140-7a6d-4800-9021-be0312abeb53", null, "Moderator", "MODERATOR" },
                    { "dc2d0d8c-2eab-400d-8caa-2fa178f6a1f6", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Necklaces",
                columns: new[] { "Id", "CriticalChance", "HealthPoints", "ItemType", "Level", "Mana", "Name", "Price", "SpriteURL", "Stamina", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 0, 6, 1, 0, "Father's Necklace", 10, "necklace0.gif", 20, 1 },
                    { 2, 0, 0, 6, 10, 40, "Necklace of Magic", 20, "necklace10.gif", 0, 3 },
                    { 3, 5, 0, 6, 20, 10, "Necklace of Fortune", 200, "necklace20.gif", 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "Rings",
                columns: new[] { "Id", "CriticalChance", "HealthPoints", "ItemType", "Level", "Mana", "Name", "Price", "SpriteURL", "Stamina", "Weight" },
                values: new object[,]
                {
                    { 1, 0, 100, 7, 1, 10, "Father's Ring", 5, "ring0.gif", 5, 1 },
                    { 2, 0, 200, 7, 10, 0, "Health Ring", 15, "ring10.gif", 10, 2 },
                    { 3, 10, 50, 7, 20, 0, "Critical Ring", 40, "ring20.gif", 0, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "957094e7-c8b0-48bb-8c20-01c0f2b5aa20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cecd7140-7a6d-4800-9021-be0312abeb53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc2d0d8c-2eab-400d-8caa-2fa178f6a1f6");

            migrationBuilder.DeleteData(
                table: "Necklaces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Necklaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Necklaces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Professions",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "SecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "Professions",
                table: "SecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Rings");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Necklaces");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Helmets");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Gloves");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Boots");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Armors");

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Weapons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "SecondaryWeapons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Rings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Necklaces",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Helmets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Gloves",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Boots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestItem",
                table: "Armors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2944c11c-e25f-41d9-a0d6-79186f0f7d40", null, "User", "USER" },
                    { "587f6133-2a8f-473b-bada-05469403befa", null, "Administrator", "ADMINISTRATOR" },
                    { "661fedf3-2fdb-4361-9c32-3e0b1e91bd97", null, "Moderator", "MODERATOR" }
                });
        }
    }
}
