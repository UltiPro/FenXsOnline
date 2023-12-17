using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class mobs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "MapMobs",
                columns: table => new
                {
                    MapId = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    MobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapMobs", x => new { x.MapId, x.X, x.Y });
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16b6ec20-ed8a-42ff-8d8d-c46650c82393", null, "User", "USER" },
                    { "36231d7e-f87b-4cf1-8d79-c37424986cba", null, "Administrator", "ADMINISTRATOR" },
                    { "8d51dea4-9b17-4bed-976e-83b33ad0f573", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "MapMobs",
                columns: new[] { "MapId", "X", "Y", "MobId" },
                values: new object[,]
                {
                    { 1, 1, 43, 1 },
                    { 1, 1, 50, 1 },
                    { 1, 1, 61, 1 },
                    { 1, 3, 39, 1 },
                    { 1, 5, 86, 1 },
                    { 1, 6, 46, 1 },
                    { 1, 6, 51, 1 },
                    { 1, 9, 66, 1 },
                    { 1, 12, 88, 1 },
                    { 1, 16, 89, 1 },
                    { 1, 19, 83, 1 },
                    { 1, 26, 91, 1 },
                    { 1, 29, 94, 1 },
                    { 1, 40, 89, 1 },
                    { 1, 40, 93, 1 },
                    { 1, 42, 73, 1 },
                    { 1, 47, 73, 1 },
                    { 1, 47, 92, 1 },
                    { 1, 48, 88, 1 },
                    { 1, 51, 75, 1 },
                    { 1, 52, 60, 1 },
                    { 1, 53, 12, 1 },
                    { 1, 53, 26, 1 },
                    { 1, 53, 65, 1 },
                    { 1, 53, 94, 1 },
                    { 1, 54, 92, 1 },
                    { 1, 55, 13, 1 },
                    { 1, 55, 19, 1 },
                    { 1, 55, 25, 1 },
                    { 1, 55, 63, 1 },
                    { 1, 57, 9, 1 },
                    { 1, 57, 61, 1 },
                    { 1, 57, 94, 1 },
                    { 1, 58, 63, 1 },
                    { 1, 58, 67, 1 },
                    { 1, 59, 27, 1 },
                    { 1, 59, 53, 1 },
                    { 1, 59, 58, 1 },
                    { 1, 59, 61, 1 },
                    { 1, 59, 65, 1 },
                    { 1, 61, 60, 1 },
                    { 1, 61, 62, 1 },
                    { 1, 62, 20, 1 },
                    { 1, 62, 57, 1 },
                    { 2, 2, 9, 2 },
                    { 2, 2, 21, 2 },
                    { 2, 4, 8, 2 },
                    { 2, 4, 18, 2 },
                    { 2, 6, 22, 2 },
                    { 2, 7, 11, 2 },
                    { 2, 7, 17, 2 },
                    { 2, 8, 6, 2 },
                    { 2, 9, 20, 2 },
                    { 2, 13, 4, 2 },
                    { 2, 15, 25, 2 },
                    { 2, 16, 19, 2 },
                    { 2, 17, 5, 2 },
                    { 2, 17, 12, 2 },
                    { 2, 19, 8, 2 },
                    { 2, 22, 7, 2 },
                    { 2, 22, 14, 2 },
                    { 2, 23, 19, 2 },
                    { 2, 23, 24, 2 },
                    { 2, 24, 10, 2 },
                    { 2, 24, 22, 2 },
                    { 2, 27, 9, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapMobs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16b6ec20-ed8a-42ff-8d8d-c46650c82393");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36231d7e-f87b-4cf1-8d79-c37424986cba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d51dea4-9b17-4bed-976e-83b33ad0f573");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0964de3c-e39b-4c95-bd60-fedf0be78082", null, "User", "USER" },
                    { "7b4ba685-812d-4b52-b35a-bcd4b0d9d3bb", null, "Administrator", "ADMINISTRATOR" },
                    { "96404dd7-e0c9-401d-8849-571870e65421", null, "Moderator", "MODERATOR" }
                });
        }
    }
}
