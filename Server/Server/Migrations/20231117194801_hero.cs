using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class hero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "SecondaryWeapons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Rings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Necklaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Agility",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Armor",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArmorId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Atack",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BootsId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriticalChance",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GlovesId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gold",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HelmetId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MagicArmor",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MagicAtack",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mana",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxMana",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxStamina",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NecklaceId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Profession",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RingId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryWeaponId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Stamina",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Helmets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Gloves",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Boots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpriteURL",
                table: "Armors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "IX_Heroes_ArmorId",
                table: "Heroes",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_BootsId",
                table: "Heroes",
                column: "BootsId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_GlovesId",
                table: "Heroes",
                column: "GlovesId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_HelmetId",
                table: "Heroes",
                column: "HelmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_NecklaceId",
                table: "Heroes",
                column: "NecklaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_RingId",
                table: "Heroes",
                column: "RingId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_SecondaryWeaponId",
                table: "Heroes",
                column: "SecondaryWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_WeaponId",
                table: "Heroes",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Armors_ArmorId",
                table: "Heroes",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Boots_BootsId",
                table: "Heroes",
                column: "BootsId",
                principalTable: "Boots",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Gloves_GlovesId",
                table: "Heroes",
                column: "GlovesId",
                principalTable: "Gloves",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Helmets_HelmetId",
                table: "Heroes",
                column: "HelmetId",
                principalTable: "Helmets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Necklaces_NecklaceId",
                table: "Heroes",
                column: "NecklaceId",
                principalTable: "Necklaces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Rings_RingId",
                table: "Heroes",
                column: "RingId",
                principalTable: "Rings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_SecondaryWeapons_SecondaryWeaponId",
                table: "Heroes",
                column: "SecondaryWeaponId",
                principalTable: "SecondaryWeapons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Weapons_WeaponId",
                table: "Heroes",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Armors_ArmorId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Boots_BootsId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Gloves_GlovesId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Helmets_HelmetId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Necklaces_NecklaceId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Rings_RingId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_SecondaryWeapons_SecondaryWeaponId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Weapons_WeaponId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_ArmorId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_BootsId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_GlovesId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_HelmetId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_NecklaceId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_RingId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_SecondaryWeaponId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_WeaponId",
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
                name: "SpriteURL",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "SecondaryWeapons");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Rings");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Necklaces");

            migrationBuilder.DropColumn(
                name: "Agility",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Armor",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "ArmorId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Atack",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "BootsId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "CriticalChance",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "GlovesId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "HelmetId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MagicArmor",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MagicAtack",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Mana",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MapId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MaxMana",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MaxStamina",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "NecklaceId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "RingId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SecondaryWeaponId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Stamina",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "X",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Helmets");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Gloves");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Boots");

            migrationBuilder.DropColumn(
                name: "SpriteURL",
                table: "Armors");

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
    }
}
