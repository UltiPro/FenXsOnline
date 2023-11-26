using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class heroeq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33b73dd4-a26a-41ae-915a-1a377e3c6b39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0f4c01e-777d-4e60-a770-699b59de9db5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5a3dfb4-bd2f-4cda-a956-ef794be69003");

            migrationBuilder.CreateTable(
                name: "HeroesEquipments",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesEquipments", x => new { x.HeroId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_HeroesEquipments_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a8278a3-78a0-405d-9d0f-d6444d78e4c4", null, "Administrator", "ADMINISTRATOR" },
                    { "9ce37f33-96e9-49e6-95d4-9a11303fa477", null, "Moderator", "MODERATOR" },
                    { "c4593731-59d3-411a-a2f3-8f312d50b744", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroesEquipments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a8278a3-78a0-405d-9d0f-d6444d78e4c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ce37f33-96e9-49e6-95d4-9a11303fa477");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4593731-59d3-411a-a2f3-8f312d50b744");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33b73dd4-a26a-41ae-915a-1a377e3c6b39", null, "User", "USER" },
                    { "c0f4c01e-777d-4e60-a770-699b59de9db5", null, "Moderator", "MODERATOR" },
                    { "e5a3dfb4-bd2f-4cda-a956-ef794be69003", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
