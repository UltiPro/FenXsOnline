using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionsAndNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Profession",
                table: "Helmets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Profession",
                table: "Gloves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Profession",
                table: "Boots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Profession",
                table: "Armors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Armors",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 30, 5, 2, 1, 0, "Red Caftan", 20, 0, "armorWarrior0.gif", 5 },
                    { 2, 10, 20, 0, 2, 1, 0, "Leather Armor", 20, 1, "armorHunter0.gif", 3 },
                    { 3, 5, 5, 20, 2, 1, 15, "Wanderer's Coat", 20, 2, "armorMage0.gif", 3 },
                    { 4, 0, 10, 10, 2, 1, 10, "Incomplete Armor", 20, 3, "armorPaladin0.gif", 7 },
                    { 5, 0, 55, 15, 2, 10, 0, "Wanderer's Chainmail", 50, 0, "armorWarrior10.gif", 10 },
                    { 6, 25, 25, 5, 2, 10, 0, "Tunic Of Agility", 35, 1, "armorHunter10.gif", 5 },
                    { 7, 5, 15, 20, 2, 10, 35, "Novice's Coat", 30, 2, "armorMage10.gif", 5 },
                    { 8, 0, 25, 10, 2, 10, 25, "Steel Breastplate", 55, 3, "armorPaladin10.gif", 15 },
                    { 9, 5, 100, 30, 2, 20, 0, "Reinforced Wanderer's Chainmail", 250, 0, "armorWarrior20.gif", 15 },
                    { 10, 15, 65, 35, 2, 20, 0, "Hunter's Tunic", 150, 1, "armorHunter20.gif", 10 },
                    { 11, 5, 30, 50, 2, 20, 95, "Thinker's Coat", 200, 2, "armorMage20.gif", 8 },
                    { 12, 0, 75, 50, 2, 20, 75, "Guardian Armor", 350, 3, "armorPaladin20.gif", 20 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45ebec92-ccba-4bf0-ab66-11234b791d23", null, "Administrator", "ADMINISTRATOR" },
                    { "47996798-1f62-4f28-9167-e03963a7e128", null, "User", "USER" },
                    { "80e8988f-d697-4c4e-a46f-3c91094b782f", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "Boots",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 5, 0, 4, 1, 0, "Chainmail Boots", 5, 0, "bootsWarrior0.gif", 2 },
                    { 2, 5, 1, 5, 4, 1, 0, "Sheepskin Boots", 1, 1, "bootsHunter0.gif", 1 },
                    { 3, 2, 1, 3, 4, 1, 5, "Leather Slippers", 2, 2, "bootsMage0.gif", 1 },
                    { 4, 0, 15, 0, 4, 1, 5, "Steel Boots", 10, 3, "bootsPaladin0.gif", 3 }
                });

            migrationBuilder.InsertData(
                table: "Gloves",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 0, 10, 5, 5, 1, 0, "Steel Bracelets", 5, 0, "glovesWarrior0.gif", 4 },
                    { 2, 5, 5, 5, 5, 1, 0, "Leather Gloves", 2, 1, "glovesHunter0.gif", 2 },
                    { 3, 0, 2, 5, 5, 1, 8, "Black Gloves", 3, 2, "glovesMage0.gif", 2 },
                    { 4, -2, 10, 0, 5, 1, 5, "Iron Paws", 5, 3, "glovesPaladin0.gif", 4 }
                });

            migrationBuilder.InsertData(
                table: "Helmets",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 0, 5, 0, 3, 1, 0, "Copper Helmet", 10, 0, "helmetWarrior0.gif", 3 },
                    { 2, 0, 1, 5, 3, 1, 0, "Wanderer's Hat", 2, 1, "helmetHunter0.gif", 1 },
                    { 3, 0, 1, 10, 3, 1, 10, "Magician's Hat", 5, 2, "helmetMage0.gif", 2 },
                    { 4, 0, 5, 0, 3, 1, 10, "Zinc Helmet", 10, 3, "helmetPaladin0.gif", 3 },
                    { 5, -5, 40, 15, 3, 10, 0, "Viking Helmet", 30, 0, "helmetWarrior10.gif", 7 },
                    { 6, 5, 10, 10, 3, 10, 0, "Elf Hat", 15, 1, "helmetHunter10.gif", 2 },
                    { 7, 0, 1, 30, 3, 10, 10, "Student Cap", 5, 2, "helmetMage10.gif", 1 },
                    { 8, 0, 25, 5, 3, 10, 15, "Steel Helmet", 10, 3, "helmetPaladin10.gif", 6 },
                    { 9, 5, 30, 15, 3, 20, 0, "Battle Helmet", 100, 0, "helmetWarrior20.gif", 6 },
                    { 10, 25, 10, 5, 3, 20, 0, "Agility Hood", 40, 1, "helmetHunter20.gif", 2 },
                    { 11, 5, 15, 15, 3, 20, 15, "Helmet of Versatility", 200, 2, "helmetMage20.gif", 4 },
                    { 12, 0, 30, 10, 3, 20, 25, "Gilded Helmet", 100, 3, "helmetPaladin20.gif", 6 },
                    { 13, 0, 100, 0, 3, 30, 0, "Tournament Visor", 250, 0, "helmetWarrior30.gif", 7 },
                    { 14, 5, 65, 30, 3, 30, 0, "Bear Hat", 175, 1, "helmetHunter30.gif", 3 },
                    { 15, 10, 50, 40, 3, 30, 50, "Magical Hat Of The Crimson Avenger", 450, 2, "helmetMage30.gif", 2 },
                    { 16, 0, 85, 35, 3, 30, 45, "Helmet Of The Order", 300, 3, "helmetPaladin30.gif", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Sword Of Glory");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Victors' Saber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Armors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45ebec92-ccba-4bf0-ab66-11234b791d23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47996798-1f62-4f28-9167-e03963a7e128");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80e8988f-d697-4c4e-a46f-3c91094b782f");

            migrationBuilder.DeleteData(
                table: "Boots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gloves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gloves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gloves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gloves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Helmets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Helmets");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Gloves");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Boots");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Armors");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93459483-f004-44d4-83a7-e9c2221fb547", null, "User", "USER" },
                    { "eee71abd-77df-460b-bfca-881a02cac00f", null, "Administrator", "ADMINISTRATOR" },
                    { "fb370d81-2bdb-43a1-9acf-78ba49e0e118", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Victors' Saber");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Obsidian Sword");
        }
    }
}
