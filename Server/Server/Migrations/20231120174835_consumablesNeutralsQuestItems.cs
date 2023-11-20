using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class consumablesNeutralsQuestItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Consumables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Neutrals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neutrals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5cfea539-7c9a-454e-8474-ffa5bb0cfab8", null, "Administrator", "ADMINISTRATOR" },
                    { "cb98cb6d-0059-4be1-820c-25bc56a5c7a6", null, "Moderator", "MODERATOR" },
                    { "fb669caa-6177-42c3-9a39-6609bab4466d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Consumables",
                columns: new[] { "Id", "Gold", "HealthPoints", "ItemType", "Mana", "Name", "Price", "SpriteURL", "Stamina" },
                values: new object[,]
                {
                    { 1, 0, 10, 8, 0, "Small Health Potion", 20, "potionHealthSmall.gif", 0 },
                    { 2, 0, 0, 8, 0, "Small Stamina Potion", 50, "potionStaminaSmall.gif", 10 },
                    { 3, 0, 0, 8, 10, "Small Mana Potion", 50, "potionManaSmall.gif", 0 },
                    { 4, 0, 30, 8, 0, "Medium Health Potion", 100, "potionHealthMedium.gif", 0 },
                    { 5, 0, 0, 8, 0, "Medium Stamina Potion", 200, "potionStaminaMedium.gif", 30 },
                    { 6, 0, 0, 8, 30, "Medium Mana Potion", 200, "potionManaMedium.gif", 0 },
                    { 7, 0, 100, 8, 0, "Large Health Potion", 1000, "potionHealthLarge.gif", 0 },
                    { 8, 0, 0, 8, 0, "Large Stamina Potion", 2000, "potionStaminaLarge.gif", 100 },
                    { 9, 0, 0, 8, 100, "Large Mana Potion", 2000, "potionManaLarge.gif", 0 },
                    { 10, 0, 2, 8, 0, "Apple", 3, "apple.gif", 0 },
                    { 11, 0, 5, 8, 0, "Meat", 8, "meat.gif", 0 },
                    { 12, 0, -10, 8, 5, "Night Mashroom", 5, "nightMashroom.gif", 5 },
                    { 13, 15, 0, 8, 0, "Pile Of Coins", 0, "pileOfCoins.gif", 0 }
                });

            migrationBuilder.InsertData(
                table: "Neutrals",
                columns: new[] { "Id", "Description", "ItemType", "Name", "Price", "SpriteURL" },
                values: new object[,]
                {
                    { 1, "", 9, "Feather", 1, "feather.gif" },
                    { 2, "", 9, "Boar Leather", 25, "boarLeather.gif" },
                    { 3, "", 9, "Boar Tusk", 10, "boarTusk.gif" },
                    { 4, "", 9, "Boar Tail", 5, "boarTail.gif" },
                    { 5, "", 9, "Wolf Tusk", 15, "wolfTusk.gif" },
                    { 6, "Strong poison, some craftsmen may be interested in it.", 9, "Spider Poison", 50, "spiderPoison.gif" },
                    { 7, "Wonder if it can be useful for something?", 9, "Powder", 5, "powder.gif" },
                    { 8, "Rare expensive stone.", 9, "Jasper", 150, "jasper.gif" },
                    { 9, "", 9, "Cloth", 5, "cloth.gif" },
                    { 10, "", 9, "Wood", 100, "wood.gif" },
                    { 11, "Raw material.", 9, "Iron Nuggets", 200, "ironNuggets.gif" },
                    { 12, "Useful in crafts.", 9, "Iron Ingot", 1000, "ironIngot.gif" },
                    { 13, "Precious item.", 9, "Blue Crystal", 350, "blueCrystal.gif" },
                    { 14, "Wonder who it belonged to?", 9, "Trinket", 500, "trinket.gif" },
                    { 15, "Wonder what's inside?", 9, "Shell", 100, "shell.gif" },
                    { 16, "Precious find in one of the shells.", 9, "Pearl", 2500, "pearl.gif" },
                    { 17, "Precious find in one of the shells. Legend has it that the red color of the pearl comes from the blood of the king murdered by his subordinates.", 9, "Blood Pearl", 5000, "bloodPearl.gif" }
                });

            migrationBuilder.InsertData(
                table: "QuestItems",
                columns: new[] { "Id", "Description", "ItemType", "Name", "SpriteURL" },
                values: new object[,]
                {
                    { 1, "The alchemist's lost book.", 10, "Alchemist's Book", "alchemistBook.gif" },
                    { 2, "", 10, "Crystal", "crystal.gif" },
                    { 3, "Will you find its destiny?", 10, "Mysterious Key", "key0.gif" },
                    { 4, "Allows you to enter the catacombs.", 10, "Key To Catacombs", "key1.gif" },
                    { 5, "The healer's lost necklace.", 10, "Healer's Necklace", "healerNecklace.gif" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumables");

            migrationBuilder.DropTable(
                name: "Neutrals");

            migrationBuilder.DropTable(
                name: "QuestItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cfea539-7c9a-454e-8474-ffa5bb0cfab8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb98cb6d-0059-4be1-820c-25bc56a5c7a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb669caa-6177-42c3-9a39-6609bab4466d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45ebec92-ccba-4bf0-ab66-11234b791d23", null, "Administrator", "ADMINISTRATOR" },
                    { "47996798-1f62-4f28-9167-e03963a7e128", null, "User", "USER" },
                    { "80e8988f-d697-4c4e-a46f-3c91094b782f", null, "Moderator", "MODERATOR" }
                });
        }
    }
}
