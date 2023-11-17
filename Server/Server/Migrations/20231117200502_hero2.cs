using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class hero2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_AspNetUsers_DBUserId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_DBUserId",
                table: "Heroes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50b91b2a-eb8e-4ac6-9af7-c37fcaa456d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "637ee985-2087-4a1e-85a3-4ae1373b983f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3825593-d338-40df-aa9a-b730aeebab8b");

            migrationBuilder.DropColumn(
                name: "DBUserId",
                table: "Heroes");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Heroes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20d0f173-9ed9-4308-b846-3e09c2887600", null, "User", "USER" },
                    { "20f211cf-52f9-4c66-8ce1-f94b4dcd8a9a", null, "Administrator", "ADMINISTRATOR" },
                    { "d2786788-787d-43c5-9bee-6c899daab9d3", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_UserId",
                table: "Heroes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_AspNetUsers_UserId",
                table: "Heroes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_AspNetUsers_UserId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_UserId",
                table: "Heroes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20d0f173-9ed9-4308-b846-3e09c2887600");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f211cf-52f9-4c66-8ce1-f94b4dcd8a9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2786788-787d-43c5-9bee-6c899daab9d3");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Heroes");

            migrationBuilder.AddColumn<string>(
                name: "DBUserId",
                table: "Heroes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50b91b2a-eb8e-4ac6-9af7-c37fcaa456d9", null, "Administrator", "ADMINISTRATOR" },
                    { "637ee985-2087-4a1e-85a3-4ae1373b983f", null, "User", "USER" },
                    { "c3825593-d338-40df-aa9a-b730aeebab8b", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_DBUserId",
                table: "Heroes",
                column: "DBUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_AspNetUsers_DBUserId",
                table: "Heroes",
                column: "DBUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
