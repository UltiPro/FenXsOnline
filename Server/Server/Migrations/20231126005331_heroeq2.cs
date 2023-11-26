using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class heroeq2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "HeroesEquipments",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ItemType",
                table: "HeroesEquipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "HeroesEquipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "866d8437-0433-4872-8cf6-c3de9bc6fca4", null, "Administrator", "ADMINISTRATOR" },
                    { "cfa14437-e0bf-4943-a45a-3fcfea7dbd02", null, "Moderator", "MODERATOR" },
                    { "f3e840db-57f4-4cb0-b129-1ea6b7d7151d", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866d8437-0433-4872-8cf6-c3de9bc6fca4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfa14437-e0bf-4943-a45a-3fcfea7dbd02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3e840db-57f4-4cb0-b129-1ea6b7d7151d");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HeroesEquipments",
                newName: "OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "ItemType",
                table: "HeroesEquipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "HeroesEquipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
