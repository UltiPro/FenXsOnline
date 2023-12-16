using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class mobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d69a4ee-0427-4c51-820b-009cb5e74d7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eafb617f-a66b-42eb-856a-019b11d19857");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1ac6a39-2a21-422b-9ed0-e8e00b9302f6");

            migrationBuilder.CreateTable(
                name: "Mobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    Atack = table.Column<int>(type: "int", nullable: false),
                    MagicAtack = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    DropChance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobsDrop",
                columns: table => new
                {
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobsDrop", x => new { x.MobId, x.ItemType, x.ItemId });
                    table.ForeignKey(
                        name: "FK_MobsDrop_Mobs_MobId",
                        column: x => x.MobId,
                        principalTable: "Mobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0964de3c-e39b-4c95-bd60-fedf0be78082", null, "User", "USER" },
                    { "7b4ba685-812d-4b52-b35a-bcd4b0d9d3bb", null, "Administrator", "ADMINISTRATOR" },
                    { "96404dd7-e0c9-401d-8849-571870e65421", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "Mobs",
                columns: new[] { "Id", "Agility", "Armor", "Atack", "CriticalChance", "DropChance", "HealthPoints", "Level", "MagicArmor", "MagicAtack", "Name", "SpriteUrl", "Weight" },
                values: new object[,]
                {
                    { 1, 15, 0, 10, 0, 50, 100, 1, 0, 0, "Rabbit", "rabbit.gif", 1 },
                    { 2, 5, 0, 20, 5, 25, 100, 5, 0, 0, "Spider", "spider.gif", 1 },
                    { 3, 10, 0, 25, 20, 25, 150, 10, 0, 0, "Wolf", "wolf.gif", 10 },
                    { 4, 10, 10, 40, 20, 25, 200, 15, 0, 0, "Boar", "boar.gif", 20 },
                    { 5, 10, 50, 50, 15, 15, 350, 20, 100, 50, "Apparition", "apparition.gif", 35 }
                });

            migrationBuilder.InsertData(
                table: "MobsDrop",
                columns: new[] { "ItemId", "ItemType", "MobId" },
                values: new object[,]
                {
                    { 11, 8, 1 },
                    { 6, 9, 2 },
                    { 5, 9, 3 },
                    { 11, 8, 4 },
                    { 2, 9, 4 },
                    { 3, 9, 4 },
                    { 4, 9, 4 },
                    { 3, 8, 5 },
                    { 7, 9, 5 },
                    { 9, 9, 5 },
                    { 14, 9, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobsDrop");

            migrationBuilder.DropTable(
                name: "Mobs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0964de3c-e39b-4c95-bd60-fedf0be78082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b4ba685-812d-4b52-b35a-bcd4b0d9d3bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96404dd7-e0c9-401d-8849-571870e65421");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d69a4ee-0427-4c51-820b-009cb5e74d7c", null, "User", "USER" },
                    { "eafb617f-a66b-42eb-856a-019b11d19857", null, "Moderator", "MODERATOR" },
                    { "f1ac6a39-2a21-422b-9ed0-e8e00b9302f6", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
