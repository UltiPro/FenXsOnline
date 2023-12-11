using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class improvementItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "QuestItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d69a4ee-0427-4c51-820b-009cb5e74d7c", null, "User", "USER" },
                    { "eafb617f-a66b-42eb-856a-019b11d19857", null, "Moderator", "MODERATOR" },
                    { "f1ac6a39-2a21-422b-9ed0-e8e00b9302f6", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Neutrals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 5);

            migrationBuilder.UpdateData(
                table: "QuestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 1);

            migrationBuilder.UpdateData(
                table: "QuestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 1);

            migrationBuilder.UpdateData(
                table: "QuestItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 1);

            migrationBuilder.UpdateData(
                table: "QuestItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 1);

            migrationBuilder.UpdateData(
                table: "QuestItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "QuestItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "866d8437-0433-4872-8cf6-c3de9bc6fca4", null, "Administrator", "ADMINISTRATOR" },
                    { "cfa14437-e0bf-4943-a45a-3fcfea7dbd02", null, "Moderator", "MODERATOR" },
                    { "f3e840db-57f4-4cb0-b129-1ea6b7d7151d", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Neutrals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 1);
        }
    }
}
