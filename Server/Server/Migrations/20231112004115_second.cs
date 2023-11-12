using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a8186b4-8c3b-432a-884c-c3768c7900c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7ac18a3-d856-40dc-8185-8b70ae02c369");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d154537c-1941-4e5f-8711-487589aad019");

            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a935ac4-cab9-48f5-9c54-e93ba25f1e3b", null, "Administrator", "ADMIN" },
                    { "4d070b6b-1e16-4280-ae33-18cb4dd3a097", null, "User", "USER" },
                    { "7b17c738-3ff5-42c0-8538-4ed82303feb1", null, "Moderator", "MOD" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a935ac4-cab9-48f5-9c54-e93ba25f1e3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d070b6b-1e16-4280-ae33-18cb4dd3a097");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b17c738-3ff5-42c0-8538-4ed82303feb1");

            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9a8186b4-8c3b-432a-884c-c3768c7900c1", null, "User", "USER" },
                    { "b7ac18a3-d856-40dc-8185-8b70ae02c369", null, "Moderator", "MOD" },
                    { "d154537c-1941-4e5f-8711-487589aad019", null, "Administrator", "ADMIN" }
                });
        }
    }
}
