using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consumables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gloves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gloves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Helmets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helmets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MapItems",
                columns: table => new
                {
                    MapId = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapItems", x => new { x.MapId, x.X, x.Y });
                });

            migrationBuilder.CreateTable(
                name: "MapMobs",
                columns: table => new
                {
                    MapId = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    MobId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapMobs", x => new { x.MapId, x.X, x.Y });
                });

            migrationBuilder.CreateTable(
                name: "Mobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    MagicAttack = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    DropChance = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Necklaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necklaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Neutrals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neutrals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Npcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHealer = table.Column<bool>(type: "bit", nullable: false),
                    IsTrader = table.Column<bool>(type: "bit", nullable: false),
                    PricePercent = table.Column<double>(type: "float", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Npcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NpcId = table.Column<int>(type: "int", nullable: false),
                    NpcMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    MagicAttack = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryWeapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    MagicAttack = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MobsDrop",
                columns: table => new
                {
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobsDrop", x => new { x.MobId, x.ItemType, x.ItemId });
                    table.ForeignKey(
                        name: "FK_MobsDrop_Mobs_MobId",
                        column: x => x.MobId,
                        principalTable: "Mobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NpcsItem",
                columns: table => new
                {
                    NpcId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcsItem", x => new { x.NpcId, x.Id });
                    table.ForeignKey(
                        name: "FK_NpcsItem_Npcs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "Npcs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestRewards",
                columns: table => new
                {
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestRewards", x => new { x.QuestId, x.ItemType, x.ItemId });
                    table.ForeignKey(
                        name: "FK_QuestRewards_Quests_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestStages",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Talk = table.Column<bool>(type: "bit", nullable: false),
                    NpcId = table.Column<int>(type: "int", nullable: true),
                    NpcMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NpcAnswear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kill = table.Column<bool>(type: "bit", nullable: false),
                    MobId = table.Column<int>(type: "int", nullable: true),
                    ItemType = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestStages", x => new { x.QuestId, x.Stage });
                    table.ForeignKey(
                        name: "FK_QuestStages_Quests_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    MagicAttack = table.Column<int>(type: "int", nullable: false),
                    CriticalChance = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    MagicArmor = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    MapId = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    InGame = table.Column<bool>(type: "bit", nullable: false),
                    Dead = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArmorId = table.Column<int>(type: "int", nullable: true),
                    BootsId = table.Column<int>(type: "int", nullable: true),
                    GlovesId = table.Column<int>(type: "int", nullable: true),
                    HelmetId = table.Column<int>(type: "int", nullable: true),
                    NecklaceId = table.Column<int>(type: "int", nullable: true),
                    RingId = table.Column<int>(type: "int", nullable: true),
                    SecondaryWeaponId = table.Column<int>(type: "int", nullable: true),
                    WeaponId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    MaxHealthPoints = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    MaxMana = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    MaxStamina = table.Column<int>(type: "int", nullable: false),
                    SpriteURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_Armors_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_Boots_BootsId",
                        column: x => x.BootsId,
                        principalTable: "Boots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_Gloves_GlovesId",
                        column: x => x.GlovesId,
                        principalTable: "Gloves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_Helmets_HelmetId",
                        column: x => x.HelmetId,
                        principalTable: "Helmets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_Necklaces_NecklaceId",
                        column: x => x.NecklaceId,
                        principalTable: "Necklaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_Rings_RingId",
                        column: x => x.RingId,
                        principalTable: "Rings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_SecondaryWeapons_SecondaryWeaponId",
                        column: x => x.SecondaryWeaponId,
                        principalTable: "SecondaryWeapons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Heroes_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HeroesEquipments",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesEquipments", x => new { x.HeroId, x.Id });
                    table.ForeignKey(
                        name: "FK_HeroesEquipments_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeroesQuests",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    QuestId = table.Column<int>(type: "int", nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesQuests", x => new { x.HeroId, x.QuestId });
                    table.ForeignKey(
                        name: "FK_HeroesQuests_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroesQuests_Quests_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Armors",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 30, 5, 2, 1, 0, "Red Caftan", 20, 0, "armorWarrior0.gif", 5 },
                    { 2, 10, 20, 0, 2, 1, 0, "Leather Armor", 20, 1, "armorHunter0.gif", 3 },
                    { 3, 5, 5, 20, 2, 1, 15, "Wanderer's Coat", 20, 2, "armorMage0.gif", 3 },
                    { 4, 0, 10, 10, 2, 1, 10, "Incomplete Armor", 20, 3, "armorPaladin0.gif", 7 },
                    { 5, 0, 55, 15, 2, 10, 0, "Wanderer's Chainmail", 50, 0, "armorWarrior10.gif", 10 },
                    { 6, 25, 25, 5, 2, 10, 0, "Tunic Of Agility", 35, 1, "armorHunter10.gif", 5 },
                    { 7, 5, 15, 20, 2, 10, 35, "Novice's Coat", 30, 2, "armorMage10.gif", 5 },
                    { 8, 0, 25, 10, 2, 10, 25, "Steel Breastplate", 55, 3, "armorPaladin10.gif", 15 },
                    { 9, 5, 100, 30, 2, 20, 0, "Reinforced Wanderer's Chainmail", 250, 0, "armorWarrior20.gif", 15 },
                    { 10, 15, 65, 35, 2, 20, 0, "Hunter's Tunic", 150, 1, "armorHunter20.gif", 10 },
                    { 11, 5, 30, 50, 2, 20, 95, "Thinker's Coat", 200, 2, "armorMage20.gif", 8 },
                    { 12, 0, 75, 50, 2, 20, 75, "Guardian Armor", 350, 3, "armorPaladin20.gif", 20 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "358269f1-1849-47b8-beae-3c53ff5cd0ea", null, "Administrator", "ADMINISTRATOR" },
                    { "9696b9d3-aafc-4412-b98e-54defa081bd9", null, "User", "USER" },
                    { "de4b723b-d2ad-4361-a258-97f95a81b2d9", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "Boots",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 5, 0, 4, 1, 0, "Chainmail Boots", 5, 0, "bootsWarrior0.gif", 2 },
                    { 2, 5, 1, 5, 4, 1, 0, "Sheepskin Boots", 1, 1, "bootsHunter0.gif", 1 },
                    { 3, 2, 1, 3, 4, 1, 5, "Leather Slippers", 2, 2, "bootsMage0.gif", 1 },
                    { 4, 0, 15, 0, 4, 1, 5, "Steel Boots", 10, 3, "bootsPaladin0.gif", 3 }
                });

            migrationBuilder.InsertData(
                table: "Consumables",
                columns: new[] { "Id", "Gold", "HealthPoints", "ItemType", "Mana", "Name", "Price", "SpriteURL", "Stamina" },
                values: new object[,]
                {
                    { 1, 0, 10, 8, 0, "Small Health Potion", 20, "potionHealthSmall.gif", 0 },
                    { 2, 0, 0, 8, 0, "Small Stamina Potion", 50, "potionStaminaSmall.gif", 10 },
                    { 3, 0, 0, 8, 10, "Small Mana Potion", 50, "potionManaSmall.gif", 0 },
                    { 4, 0, 30, 8, 0, "Medium Health Potion", 100, "potionHealthMedium.gif", 0 },
                    { 5, 0, 0, 8, 0, "Medium Stamina Potion", 200, "potionStaminaMedium.gif", 30 },
                    { 6, 0, 0, 8, 30, "Medium Mana Potion", 200, "potionManaMedium.gif", 0 },
                    { 7, 0, 100, 8, 0, "Large Health Potion", 1000, "potionHealthLarge.gif", 0 },
                    { 8, 0, 0, 8, 0, "Large Stamina Potion", 2000, "potionStaminaLarge.gif", 100 },
                    { 9, 0, 0, 8, 100, "Large Mana Potion", 2000, "potionManaLarge.gif", 0 },
                    { 10, 0, 2, 8, 0, "Apple", 3, "apple.gif", 0 },
                    { 11, 0, 5, 8, 0, "Meat", 8, "meat.gif", 0 },
                    { 12, 0, -10, 8, 5, "Night Mashroom", 5, "nightMashroom.gif", 5 },
                    { 13, 15, 0, 8, 0, "Pile Of Coins", 0, "pileOfCoins.gif", 0 }
                });

            migrationBuilder.InsertData(
                table: "Gloves",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 0, 10, 5, 5, 1, 0, "Steel Bracelets", 5, 0, "glovesWarrior0.gif", 4 },
                    { 2, 5, 5, 5, 5, 1, 0, "Leather Gloves", 2, 1, "glovesHunter0.gif", 2 },
                    { 3, 0, 2, 5, 5, 1, 8, "Black Gloves", 3, 2, "glovesMage0.gif", 2 },
                    { 4, -2, 10, 0, 5, 1, 5, "Iron Paws", 5, 3, "glovesPaladin0.gif", 4 }
                });

            migrationBuilder.InsertData(
                table: "Helmets",
                columns: new[] { "Id", "Agility", "Armor", "HealthPoints", "ItemType", "Level", "MagicArmor", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 0, 5, 0, 3, 1, 0, "Copper Helmet", 10, 0, "helmetWarrior0.gif", 3 },
                    { 2, 0, 1, 5, 3, 1, 0, "Wanderer's Hat", 2, 1, "helmetHunter0.gif", 1 },
                    { 3, 0, 1, 10, 3, 1, 10, "Magician's Hat", 5, 2, "helmetMage0.gif", 2 },
                    { 4, 0, 5, 0, 3, 1, 10, "Zinc Helmet", 10, 3, "helmetPaladin0.gif", 3 },
                    { 5, -5, 40, 15, 3, 10, 0, "Viking Helmet", 30, 0, "helmetWarrior10.gif", 7 },
                    { 6, 5, 10, 10, 3, 10, 0, "Elf Hat", 15, 1, "helmetHunter10.gif", 2 },
                    { 7, 0, 1, 30, 3, 10, 10, "Student Cap", 5, 2, "helmetMage10.gif", 1 },
                    { 8, 0, 25, 5, 3, 10, 15, "Steel Helmet", 10, 3, "helmetPaladin10.gif", 6 },
                    { 9, 5, 30, 15, 3, 20, 0, "Battle Helmet", 100, 0, "helmetWarrior20.gif", 6 },
                    { 10, 25, 10, 5, 3, 20, 0, "Agility Hood", 40, 1, "helmetHunter20.gif", 2 },
                    { 11, 5, 15, 15, 3, 20, 15, "Helmet of Versatility", 200, 2, "helmetMage20.gif", 4 },
                    { 12, 0, 30, 10, 3, 20, 25, "Gilded Helmet", 100, 3, "helmetPaladin20.gif", 6 },
                    { 13, 0, 100, 0, 3, 30, 0, "Tournament Visor", 250, 0, "helmetWarrior30.gif", 7 },
                    { 14, 5, 65, 30, 3, 30, 0, "Bear Hat", 175, 1, "helmetHunter30.gif", 3 },
                    { 15, 10, 50, 40, 3, 30, 50, "Magical Hat Of The Crimson Avenger", 450, 2, "helmetMage30.gif", 2 },
                    { 16, 0, 85, 35, 3, 30, 45, "Helmet Of The Order", 300, 3, "helmetPaladin30.gif", 5 }
                });

            migrationBuilder.InsertData(
                table: "MapItems",
                columns: new[] { "MapId", "X", "Y", "Available", "ItemId", "ItemType" },
                values: new object[,]
                {
                    { 1, 3, 49, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8370), 10, 8 },
                    { 1, 15, 69, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8367), 10, 8 },
                    { 1, 16, 94, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8318), 10, 8 },
                    { 1, 55, 43, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8372), 10, 8 },
                    { 1, 56, 71, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8373), 5, 10 },
                    { 2, 1, 2, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8433), 12, 8 },
                    { 2, 20, 12, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8430), 12, 8 }
                });

            migrationBuilder.InsertData(
                table: "MapMobs",
                columns: new[] { "MapId", "X", "Y", "Available", "MobId" },
                values: new object[,]
                {
                    { 1, 1, 43, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8608), 1 },
                    { 1, 1, 50, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8612), 1 },
                    { 1, 1, 61, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8615), 1 },
                    { 1, 3, 39, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8609), 1 },
                    { 1, 5, 86, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8602), 1 },
                    { 1, 6, 46, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8611), 1 },
                    { 1, 6, 51, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8614), 1 },
                    { 1, 9, 66, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8606), 1 },
                    { 1, 12, 88, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8595), 1 },
                    { 1, 16, 89, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8599), 1 },
                    { 1, 19, 83, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8601), 1 },
                    { 1, 26, 91, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8604), 1 },
                    { 1, 29, 94, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8605), 1 },
                    { 1, 40, 89, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8618), 1 },
                    { 1, 40, 93, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8616), 1 },
                    { 1, 42, 73, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8655), 1 },
                    { 1, 47, 73, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8656), 1 },
                    { 1, 47, 92, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8652), 1 },
                    { 1, 48, 88, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8653), 1 },
                    { 1, 51, 75, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8658), 1 },
                    { 1, 52, 60, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8667), 1 },
                    { 1, 53, 12, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8683), 1 },
                    { 1, 53, 26, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8679), 1 },
                    { 1, 53, 65, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8660), 1 },
                    { 1, 53, 94, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8650), 1 },
                    { 1, 54, 92, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8620), 1 },
                    { 1, 55, 13, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8685), 1 },
                    { 1, 55, 19, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8682), 1 },
                    { 1, 55, 25, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8678), 1 },
                    { 1, 55, 63, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8666), 1 },
                    { 1, 57, 9, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8686), 1 },
                    { 1, 57, 61, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8669), 1 },
                    { 1, 57, 94, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8619), 1 },
                    { 1, 58, 63, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8664), 1 },
                    { 1, 58, 67, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8659), 1 },
                    { 1, 59, 27, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8677), 1 },
                    { 1, 59, 53, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8675), 1 },
                    { 1, 59, 58, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8674), 1 },
                    { 1, 59, 61, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8670), 1 },
                    { 1, 59, 65, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8662), 1 },
                    { 1, 61, 60, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8671), 1 },
                    { 1, 61, 62, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8663), 1 },
                    { 1, 62, 20, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8681), 1 },
                    { 1, 62, 57, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8673), 1 },
                    { 2, 2, 9, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8783), 2 },
                    { 2, 2, 21, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8756), 2 },
                    { 2, 4, 8, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8782), 2 },
                    { 2, 4, 18, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8757), 2 },
                    { 2, 6, 22, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8754), 2 },
                    { 2, 7, 11, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8781), 2 },
                    { 2, 7, 17, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8759), 2 },
                    { 2, 8, 6, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8779), 2 },
                    { 2, 9, 20, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8760), 2 },
                    { 2, 13, 4, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8778), 2 },
                    { 2, 15, 25, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8752), 2 },
                    { 2, 16, 19, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8770), 2 },
                    { 2, 17, 5, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8775), 2 },
                    { 2, 17, 12, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8768), 2 },
                    { 2, 19, 8, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8776), 2 },
                    { 2, 22, 7, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8772), 2 },
                    { 2, 22, 14, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8767), 2 },
                    { 2, 23, 19, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8766), 2 },
                    { 2, 23, 24, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8762), 2 },
                    { 2, 24, 10, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8771), 2 },
                    { 2, 24, 22, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8763), 2 },
                    { 2, 27, 9, new DateTime(2024, 1, 6, 23, 37, 54, 922, DateTimeKind.Local).AddTicks(8774), 2 }
                });

            migrationBuilder.InsertData(
                table: "Mobs",
                columns: new[] { "Id", "Agility", "Armor", "Attack", "CriticalChance", "DropChance", "HealthPoints", "Level", "MagicArmor", "MagicAttack", "Name", "SpriteUrl", "Weight" },
                values: new object[,]
                {
                    { 1, 15, 0, 5, 0, 50, 100, 1, 0, 0, "Rabbit", "rabbit.gif", 1 },
                    { 2, 5, 0, 10, 5, 25, 100, 5, 0, 0, "Spider", "spider.gif", 1 },
                    { 3, 10, 0, 15, 20, 25, 150, 10, 0, 0, "Wolf", "wolf.gif", 10 },
                    { 4, 10, 10, 25, 20, 25, 200, 15, 0, 0, "Boar", "boar.gif", 20 },
                    { 5, 10, 50, 25, 15, 15, 350, 20, 100, 25, "Apparition", "apparition.gif", 35 }
                });

            migrationBuilder.InsertData(
                table: "Necklaces",
                columns: new[] { "Id", "CriticalChance", "HealthPoints", "ItemType", "Level", "Mana", "Name", "Price", "SpriteURL", "Stamina", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 0, 6, 1, 0, "Father's Necklace", 10, "necklace0.gif", 20, 1 },
                    { 2, 0, 0, 6, 10, 40, "Necklace of Magic", 20, "necklace10.gif", 0, 3 },
                    { 3, 5, 0, 6, 20, 10, "Necklace of Fortune", 200, "necklace20.gif", 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "Neutrals",
                columns: new[] { "Id", "Description", "ItemType", "Name", "Price", "SpriteURL" },
                values: new object[,]
                {
                    { 1, "", 9, "Feather", 5, "feather.gif" },
                    { 2, "", 9, "Boar Leather", 25, "boarLeather.gif" },
                    { 3, "", 9, "Boar Tusk", 10, "boarTusk.gif" },
                    { 4, "", 9, "Boar Tail", 5, "boarTail.gif" },
                    { 5, "", 9, "Wolf Tusk", 15, "wolfTusk.gif" },
                    { 6, "Strong poison, some craftsmen may be interested in it.", 9, "Spider Poison", 50, "spiderPoison.gif" },
                    { 7, "Wonder if it can be useful for something?", 9, "Powder", 5, "powder.gif" },
                    { 8, "Rare expensive stone.", 9, "Jasper", 150, "jasper.gif" },
                    { 9, "", 9, "Cloth", 5, "cloth.gif" },
                    { 10, "", 9, "Wood", 100, "wood.gif" },
                    { 11, "Raw material.", 9, "Iron Nuggets", 200, "ironNuggets.gif" },
                    { 12, "Useful in crafts.", 9, "Iron Ingot", 1000, "ironIngot.gif" },
                    { 13, "Precious item.", 9, "Blue Crystal", 350, "blueCrystal.gif" },
                    { 14, "Wonder who it belonged to?", 9, "Trinket", 500, "trinket.gif" },
                    { 15, "Wonder what's inside?", 9, "Shell", 100, "shell.gif" },
                    { 16, "Precious find in one of the shells.", 9, "Pearl", 2500, "pearl.gif" },
                    { 17, "Precious find in one of the shells. Legend has it that the red color of the pearl comes from the blood of the king murdered by his subordinates.", 9, "Blood Pearl", 5000, "bloodPearl.gif" }
                });

            migrationBuilder.InsertData(
                table: "Npcs",
                columns: new[] { "Id", "IsHealer", "IsTrader", "MapId", "Name", "PricePercent", "SpriteURL", "X", "Y" },
                values: new object[,]
                {
                    { 1, true, true, 1, "Adelaide", 0.75, "adelaide.gif", 36, 49 },
                    { 2, false, true, 1, "Eldrik", 0.84999999999999998, "eldrik.gif", 19, 39 },
                    { 3, false, true, 1, "Gustaf", 0.80000000000000004, "gustaf.gif", 14, 13 },
                    { 4, false, true, 1, "Franko", 0.84999999999999998, "franko.gif", 56, 36 }
                });

            migrationBuilder.InsertData(
                table: "QuestItems",
                columns: new[] { "Id", "Description", "ItemType", "Name", "Price", "SpriteURL" },
                values: new object[,]
                {
                    { 1, "The alchemist's lost book.", 10, "Alchemist's Book", 1, "alchemistBook.gif" },
                    { 2, "", 10, "Crystal", 1, "crystal.gif" },
                    { 3, "Will you find its destiny?", 10, "Mysterious Key", 1, "key0.gif" },
                    { 4, "Allows you to enter the catacombs.", 10, "Key To Catacombs", 1, "key1.gif" },
                    { 5, "The healer's lost necklace.", 10, "Healer's Necklace", 1, "healerNecklace.gif" }
                });

            migrationBuilder.InsertData(
                table: "Quests",
                columns: new[] { "Id", "Gold", "Level", "NpcId", "NpcMessage", "Title" },
                values: new object[,]
                {
                    { 1, 100, 1, 1, "I lost my necklace somewhere around here, could you find it and bring it back to me please?", "The healer's lost necklace." },
                    { 2, 300, 3, 2, "There are too many rabbits in the area, they are destroying crops, can you take care of it?", "Rabbit plague." },
                    { 3, 300, 5, 4, "There are too many spiders in the near cave, they are so scary, can you take care of it?", "Spider plague." },
                    { 4, 500, 7, 1, "I need 3 apples for a delicious apple cake, could you deliver them to me?", "Apple pie." },
                    { 5, 500, 9, 3, "I would like to examine mushrooms from a nearby cave, could you provide them to me?", "Mysterious mushrooms." }
                });

            migrationBuilder.InsertData(
                table: "Rings",
                columns: new[] { "Id", "CriticalChance", "HealthPoints", "ItemType", "Level", "Mana", "Name", "Price", "SpriteURL", "Stamina", "Weight" },
                values: new object[,]
                {
                    { 1, 0, 100, 7, 1, 10, "Father's Ring", 5, "ring0.gif", 5, 1 },
                    { 2, 0, 200, 7, 10, 0, "Health Ring", 15, "ring10.gif", 10, 2 },
                    { 3, 10, 50, 7, 20, 0, "Critical Ring", 40, "ring20.gif", 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "SecondaryWeapons",
                columns: new[] { "Id", "Armor", "Attack", "CriticalChance", "ItemType", "Level", "MagicArmor", "MagicAttack", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 20, 0, 0, 1, 1, 0, 0, "Round Wooden Shield", 10, 0, "secondaryWarrior0.gif", 5 },
                    { 2, 0, 5, 0, 1, 1, 0, 0, "Arrow", 1, 1, "secondaryHunter0.gif", 1 },
                    { 3, 0, 0, 3, 1, 1, 0, 0, "School Spell Book", 5, 2, "secondaryMage0.gif", 2 },
                    { 4, 10, 0, 0, 1, 1, 5, 0, "Beginner's Shield", 10, 3, "secondaryPaladin0.gif", 5 },
                    { 5, 40, 0, 2, 1, 10, 0, 0, "Knight's Shield", 20, 0, "secondaryWarrior10.gif", 5 },
                    { 6, 0, 10, 5, 1, 10, 0, 0, "Fire Arrow", 2, 1, "secondaryHunter10.gif", 1 },
                    { 7, 0, 0, 7, 1, 10, 0, 5, "Book Of Spells", 10, 2, "secondaryMage10.gif", 2 },
                    { 8, 15, 0, 2, 1, 10, 15, 0, "Friar's Shield", 25, 3, "secondaryPaladin10.gif", 5 },
                    { 9, 65, 0, 5, 1, 20, 0, 0, "Shield Of The Damned", 50, 0, "secondaryWarrior20.gif", 6 },
                    { 10, 0, 25, 5, 1, 20, 0, 0, "Poisoned Arrow", 20, 1, "secondaryHunter20.gif", 1 },
                    { 11, 0, 0, 2, 1, 20, 0, 50, "The Sorcerer's Book", 100, 2, "secondaryMage20.gif", 3 },
                    { 12, 25, 0, 3, 1, 20, 25, 0, "Shield Of The Order", 75, 3, "secondaryPaladin20.gif", 6 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Attack", "CriticalChance", "ItemType", "Level", "MagicAttack", "Name", "Price", "Profession", "SpriteURL", "Weight" },
                values: new object[,]
                {
                    { 1, 20, 0, 0, 1, 0, "Beginner's Sword", 10, 0, "primaryWarrior0.gif", 5 },
                    { 2, 10, 0, 0, 1, 0, "Slingshot", 10, 1, "primaryHunter0.gif", 3 },
                    { 3, 0, 0, 0, 1, 15, "Beginner's Staff", 10, 2, "primaryMage0.gif", 4 },
                    { 4, 15, 0, 0, 1, 5, "Blunt Sword", 10, 3, "primaryPaladin0.gif", 5 },
                    { 5, 40, 0, 0, 10, 0, "Sword Of Glory", 50, 0, "primaryWarrior10.gif", 7 },
                    { 6, 25, 5, 0, 10, 0, "Recurve Bow", 50, 1, "primaryHunter10.gif", 4 },
                    { 7, 0, 2, 0, 10, 30, "Staff of Serpents", 50, 2, "primaryMage10.gif", 5 },
                    { 8, 30, 0, 0, 10, 15, "Broad sword", 50, 3, "primaryPaladin10.gif", 8 },
                    { 9, 80, 2, 0, 20, 0, "Victors' Saber", 150, 0, "primaryWarrior20.gif", 8 },
                    { 10, 55, 10, 0, 20, 0, "Orc Bow", 150, 1, "primaryHunter20.gif", 5 },
                    { 11, 0, 5, 0, 20, 60, "Staff of the Woods", 150, 2, "primaryMage20.gif", 7 },
                    { 12, 70, 5, 0, 20, 5, "Upgraded Broad sword", 150, 3, "primaryPaladin20.gif", 9 },
                    { 13, 120, 5, 0, 30, 0, "Sword Of Darkness", 350, 0, "primaryWarrior30.gif", 8 },
                    { 14, 70, 15, 0, 30, 0, "Bow Of Darkness", 350, 1, "primaryHunter30.gif", 6 },
                    { 15, 0, 5, 0, 30, 90, "Staff of the Order", 350, 2, "primaryMage30.gif", 7 },
                    { 16, 110, 0, 0, 30, 40, "Sword of the Order", 350, 3, "primaryPaladin30.gif", 8 }
                });

            migrationBuilder.InsertData(
                table: "MobsDrop",
                columns: new[] { "ItemId", "ItemType", "MobId" },
                values: new object[,]
                {
                    { 11, 8, 1 },
                    { 6, 9, 2 },
                    { 5, 9, 3 },
                    { 11, 8, 4 },
                    { 2, 9, 4 },
                    { 3, 9, 4 },
                    { 4, 9, 4 },
                    { 3, 8, 5 },
                    { 7, 9, 5 },
                    { 9, 9, 5 },
                    { 14, 9, 5 }
                });

            migrationBuilder.InsertData(
                table: "NpcsItem",
                columns: new[] { "Id", "NpcId", "ItemId", "ItemType" },
                values: new object[,]
                {
                    { 1, 1, 1, 8 },
                    { 2, 1, 4, 8 },
                    { 3, 1, 7, 8 },
                    { 7, 1, 2, 8 },
                    { 8, 1, 5, 8 },
                    { 9, 1, 8, 8 },
                    { 13, 1, 3, 8 },
                    { 14, 1, 6, 8 },
                    { 15, 1, 9, 8 },
                    { 1, 2, 1, 0 },
                    { 2, 2, 5, 0 },
                    { 3, 2, 9, 0 },
                    { 4, 2, 13, 0 },
                    { 7, 2, 2, 0 },
                    { 8, 2, 6, 0 },
                    { 9, 2, 10, 0 },
                    { 10, 2, 14, 0 },
                    { 13, 2, 3, 0 },
                    { 14, 2, 7, 0 },
                    { 15, 2, 11, 0 },
                    { 16, 2, 15, 0 },
                    { 19, 2, 4, 0 },
                    { 20, 2, 8, 0 },
                    { 21, 2, 12, 0 },
                    { 22, 2, 16, 0 },
                    { 25, 2, 1, 1 },
                    { 26, 2, 5, 1 },
                    { 27, 2, 9, 1 },
                    { 31, 2, 2, 1 },
                    { 32, 2, 6, 1 },
                    { 33, 2, 10, 1 },
                    { 37, 2, 3, 1 },
                    { 38, 2, 7, 1 },
                    { 39, 2, 11, 1 },
                    { 43, 2, 4, 1 },
                    { 44, 2, 8, 1 },
                    { 45, 2, 12, 1 },
                    { 1, 3, 1, 7 },
                    { 2, 3, 2, 7 },
                    { 3, 3, 3, 7 },
                    { 7, 3, 1, 6 },
                    { 8, 3, 2, 6 },
                    { 9, 3, 3, 6 },
                    { 1, 4, 1, 3 },
                    { 2, 4, 2, 3 },
                    { 3, 4, 3, 3 },
                    { 4, 4, 4, 3 },
                    { 5, 4, 13, 3 },
                    { 6, 4, 14, 3 },
                    { 7, 4, 5, 3 },
                    { 8, 4, 6, 3 },
                    { 9, 4, 7, 3 },
                    { 10, 4, 8, 3 },
                    { 11, 4, 15, 3 },
                    { 12, 4, 16, 3 },
                    { 13, 4, 9, 3 },
                    { 14, 4, 10, 3 },
                    { 15, 4, 11, 3 },
                    { 16, 4, 12, 3 },
                    { 19, 4, 1, 2 },
                    { 20, 4, 2, 2 },
                    { 21, 4, 3, 2 },
                    { 22, 4, 4, 2 },
                    { 25, 4, 5, 2 },
                    { 26, 4, 6, 2 },
                    { 27, 4, 7, 2 },
                    { 28, 4, 8, 2 },
                    { 31, 4, 9, 2 },
                    { 32, 4, 10, 2 },
                    { 33, 4, 11, 2 },
                    { 34, 4, 12, 2 },
                    { 37, 4, 1, 5 },
                    { 38, 4, 2, 5 },
                    { 39, 4, 3, 5 },
                    { 40, 4, 4, 5 },
                    { 43, 4, 1, 4 },
                    { 44, 4, 2, 4 },
                    { 45, 4, 3, 4 },
                    { 46, 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "QuestRewards",
                columns: new[] { "ItemId", "ItemType", "QuestId", "Quantity" },
                values: new object[,]
                {
                    { 1, 8, 1, 1 },
                    { 8, 9, 4, 1 },
                    { 10, 9, 5, 1 },
                    { 11, 9, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "QuestStages",
                columns: new[] { "QuestId", "Stage", "Description", "ItemId", "ItemType", "Kill", "MobId", "NpcAnswear", "NpcId", "NpcMessage", "Quantity", "Talk" },
                values: new object[,]
                {
                    { 1, 1, "Find the healer's necklace and bring it to her.", 5, 10, false, null, "Thank you very much, here is your reward.", 1, "I found your necklace.", 1, true },
                    { 2, 1, "Kill 30 rabbits.", null, null, true, 1, null, null, null, 30, false },
                    { 2, 2, "Tell Eldrik that you have killed enough rabbits.", null, null, false, null, "Thank you very much, here is your reward.", 2, "I killed rabbits.", null, true },
                    { 3, 1, "Kill 30 spiders.", null, null, true, 2, null, null, null, 30, false },
                    { 3, 2, "Tell Franko that you have killed enough spiders.", null, null, false, null, "Thank you very much, here is your reward.", 4, "I killed spiders.", null, true },
                    { 4, 1, "Bring 3 apples for cake to Adelaide.", 10, 8, false, null, "Thank you very much, here is your reward.", 1, "I brought you three apples.", 3, true },
                    { 5, 1, "Bring 5 night mashroom to Gustaf.", 12, 8, false, null, "Thank you very much, here is your reward.", 3, "I brought you five night mashrooms.", 5, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Heroes_Name",
                table: "Heroes",
                column: "Name",
                unique: true);

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
                name: "IX_Heroes_UserId",
                table: "Heroes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_WeaponId",
                table: "Heroes",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroesQuests_QuestId",
                table: "HeroesQuests",
                column: "QuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Consumables");

            migrationBuilder.DropTable(
                name: "HeroesEquipments");

            migrationBuilder.DropTable(
                name: "HeroesQuests");

            migrationBuilder.DropTable(
                name: "MapItems");

            migrationBuilder.DropTable(
                name: "MapMobs");

            migrationBuilder.DropTable(
                name: "MobsDrop");

            migrationBuilder.DropTable(
                name: "Neutrals");

            migrationBuilder.DropTable(
                name: "NpcsItem");

            migrationBuilder.DropTable(
                name: "QuestItems");

            migrationBuilder.DropTable(
                name: "QuestRewards");

            migrationBuilder.DropTable(
                name: "QuestStages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Mobs");

            migrationBuilder.DropTable(
                name: "Npcs");

            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Boots");

            migrationBuilder.DropTable(
                name: "Gloves");

            migrationBuilder.DropTable(
                name: "Helmets");

            migrationBuilder.DropTable(
                name: "Necklaces");

            migrationBuilder.DropTable(
                name: "Rings");

            migrationBuilder.DropTable(
                name: "SecondaryWeapons");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
