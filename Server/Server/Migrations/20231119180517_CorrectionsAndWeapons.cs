using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionsAndWeapons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Professions",
                table: "Weapons",
                newName: "Profession");

            migrationBuilder.RenameColumn(
                name: "Professions",
                table: "SecondaryWeapons",
                newName: "Profession");

            migrationBuilder.AddColumn<int>(
                name: "Armor",
                table: "SecondaryWeapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MagicArmor",
                table: "SecondaryWeapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93459483-f004-44d4-83a7-e9c2221fb547", null, "User", "USER" },
                    { "eee71abd-77df-460b-bfca-881a02cac00f", null, "Administrator", "ADMINISTRATOR" },
                    { "fb370d81-2bdb-43a1-9acf-78ba49e0e118", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Armor", "Atack", "CriticalChance", "ItemType", "Level", "MagicArmor", "MagicAtack", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 20, 0, 0, 1, 1, 0, 0, "Round Wooden Shield", 10, 0, "secondaryWarrior0.gif", 5 },
                    { 2, 0, 5, 0, 1, 1, 0, 0, "Arrow", 1, 1, "secondaryHunter0.gif", 1 },
                    { 3, 0, 0, 3, 1, 1, 0, 0, "School Spell Book", 5, 2, "secondaryMage0.gif", 2 },
                    { 4, 10, 0, 0, 1, 1, 5, 0, "Beginner's Shield", 10, 3, "secondaryPaladin0.gif", 5 },
                    { 5, 40, 0, 2, 1, 10, 0, 0, "Knight's Shield", 20, 0, "secondaryWarrior10.gif", 5 },
                    { 6, 0, 10, 5, 1, 10, 0, 0, "Fire Arrow", 2, 1, "secondaryHunter10.gif", 1 },
                    { 7, 0, 0, 7, 1, 10, 0, 5, "Book Of Spells", 10, 2, "secondaryMage10.gif", 2 },
                    { 8, 15, 0, 2, 1, 10, 15, 0, "Friar's Shield", 25, 3, "secondaryPaladin10.gif", 5 },
                    { 9, 65, 0, 5, 1, 20, 0, 0, "Shield Of The Damned", 50, 0, "secondaryWarrior20.gif", 6 },
                    { 10, 0, 25, 5, 1, 20, 0, 0, "Poisoned Arrow", 20, 1, "secondaryHunter20.gif", 1 },
                    { 11, 0, 0, 2, 1, 20, 0, 50, "The Sorcerer's Book", 100, 2, "secondaryMage20.gif", 3 },
                    { 12, 25, 0, 3, 1, 20, 25, 0, "Shield Of The Order", 75, 3, "secondaryPaladin20.gif", 6 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Atack", "CriticalChance", "ItemType", "Level", "MagicAtack", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 20, 0, 0, 1, 0, "Beginner's Sword", 10, 0, "primaryWarrior0.gif", 5 },
                    { 2, 10, 0, 0, 1, 0, "Slingshot", 10, 1, "primaryHunter0.gif", 3 },
                    { 3, 0, 0, 0, 1, 15, "Beginner's Staff", 10, 2, "primaryMage0.gif", 4 },
                    { 4, 15, 0, 0, 1, 5, "Blunt Sword", 10, 3, "primaryPaladin0.gif", 5 },
                    { 5, 40, 0, 0, 10, 0, "Victors' Saber", 50, 0, "primaryWarrior10.gif", 7 },
                    { 6, 25, 5, 0, 10, 0, "Recurve Bow", 50, 1, "primaryHunter10.gif", 4 },
                    { 7, 0, 2, 0, 10, 30, "Staff of Serpents", 50, 2, "primaryMage10.gif", 5 },
                    { 8, 30, 0, 0, 10, 15, "Broad sword", 50, 3, "primaryPaladin10.gif", 8 },
                    { 9, 80, 2, 0, 20, 0, "Obsidian Sword", 150, 0, "primaryWarrior20.gif", 8 },
                    { 10, 55, 10, 0, 20, 0, "Orc Bow", 150, 1, "primaryHunter20.gif", 5 },
                    { 11, 0, 5, 0, 20, 60, "Staff of the Woods", 150, 2, "primaryMage20.gif", 7 },
                    { 12, 70, 5, 0, 20, 5, "Upgraded Broad sword", 150, 3, "primaryPaladin20.gif", 9 },
                    { 13, 120, 5, 0, 30, 0, "Sword Of Darkness", 350, 0, "primaryWarrior30.gif", 8 },
                    { 14, 70, 15, 0, 30, 0, "Bow Of Darkness", 350, 1, "primaryHunter30.gif", 6 },
                    { 15, 0, 5, 0, 30, 90, "Staff of the Order", 350, 2, "primaryMage30.gif", 7 },
                    { 16, 110, 0, 0, 30, 40, "Sword of the Order", 350, 3, "primaryPaladin30.gif", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93459483-f004-44d4-83a7-e9c2221fb547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eee71abd-77df-460b-bfca-881a02cac00f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb370d81-2bdb-43a1-9acf-78ba49e0e118");

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SecondaryWeapons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "Armor",
                table: "SecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "MagicArmor",
                table: "SecondaryWeapons");

            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "Weapons",
                newName: "Professions");

            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "SecondaryWeapons",
                newName: "Professions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "957094e7-c8b0-48bb-8c20-01c0f2b5aa20", null, "User", "USER" },
                    { "cecd7140-7a6d-4800-9021-be0312abeb53", null, "Moderator", "MODERATOR" },
                    { "dc2d0d8c-2eab-400d-8caa-2fa178f6a1f6", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
