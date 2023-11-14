using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class dbupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14523996-2a92-465b-827e-db82abbba65d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "220f18fe-86d8-4ad4-8258-e9d69e062fab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0f4d829-9892-4389-80cc-de9d9cb03d7b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2159b142-2fbf-4073-a01a-65429fcfe064", null, "Moderator", "MODERATOR" },
                    { "859febee-6351-40c9-b879-a9f480b458f1", null, "Administrator", "ADMINISTRATOR" },
                    { "8d82a973-eb2f-44bb-b744-b641122a8d9e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2159b142-2fbf-4073-a01a-65429fcfe064");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "859febee-6351-40c9-b879-a9f480b458f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d82a973-eb2f-44bb-b744-b641122a8d9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14523996-2a92-465b-827e-db82abbba65d", null, "Moderator", "MOD" },
                    { "220f18fe-86d8-4ad4-8258-e9d69e062fab", null, "User", "USER" },
                    { "a0f4d829-9892-4389-80cc-de9d9cb03d7b", null, "Administrator", "ADMIN" }
                });
        }
    }
}
