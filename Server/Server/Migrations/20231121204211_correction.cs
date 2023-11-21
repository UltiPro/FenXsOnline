using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "IsDead",
                table: "Heroes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dead",
                table: "Heroes",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Dead",
                table: "Heroes");

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
                    { "5cfea539-7c9a-454e-8474-ffa5bb0cfab8", null, "Administrator", "ADMINISTRATOR" },
                    { "cb98cb6d-0059-4be1-820c-25bc56a5c7a6", null, "Moderator", "MODERATOR" },
                    { "fb669caa-6177-42c3-9a39-6609bab4466d", null, "User", "USER" }
                });
        }
    }
}
