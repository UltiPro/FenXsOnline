using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class hero3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Heroes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "InGame",
                table: "Heroes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDead",
                table: "Heroes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2944c11c-e25f-41d9-a0d6-79186f0f7d40", null, "User", "USER" },
                    { "587f6133-2a8f-473b-bada-05469403befa", null, "Administrator", "ADMINISTRATOR" },
                    { "661fedf3-2fdb-4361-9c32-3e0b1e91bd97", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_Name",
                table: "Heroes",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Heroes_Name",
                table: "Heroes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2944c11c-e25f-41d9-a0d6-79186f0f7d40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "587f6133-2a8f-473b-bada-05469403befa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "661fedf3-2fdb-4361-9c32-3e0b1e91bd97");

            migrationBuilder.DropColumn(
                name: "InGame",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "IsDead",
                table: "Heroes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20d0f173-9ed9-4308-b846-3e09c2887600", null, "User", "USER" },
                    { "20f211cf-52f9-4c66-8ce1-f94b4dcd8a9a", null, "Administrator", "ADMINISTRATOR" },
                    { "d2786788-787d-43c5-9bee-6c899daab9d3", null, "Moderator", "MODERATOR" }
                });
        }
    }
}
