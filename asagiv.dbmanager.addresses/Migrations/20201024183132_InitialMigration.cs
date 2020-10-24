using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace asagiv.dbmanager.addresses.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BabyGifts",
                columns: table => new
                {
                    giftId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    giftDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BabyGifts", x => x.giftId);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    familyId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    familyName = table.Column<string>(nullable: true),
                    addressHeader = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.familyId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    addressId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    familyId = table.Column<long>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.addressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Families_familyId",
                        column: x => x.familyId,
                        principalTable: "Families",
                        principalColumn: "familyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyBabyGifts",
                columns: table => new
                {
                    familyBabyGiftId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    familyId = table.Column<long>(nullable: false),
                    babyGiftId = table.Column<long>(nullable: false),
                    thankYouNoteWritten = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyBabyGifts", x => x.familyBabyGiftId);
                    table.ForeignKey(
                        name: "FK_FamilyBabyGifts_BabyGifts_babyGiftId",
                        column: x => x.babyGiftId,
                        principalTable: "BabyGifts",
                        principalColumn: "giftId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyBabyGifts_Families_familyId",
                        column: x => x.familyId,
                        principalTable: "Families",
                        principalColumn: "familyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    personId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    familyId = table.Column<long>(nullable: false),
                    personName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.personId);
                    table.ForeignKey(
                        name: "FK_Person_Families_familyId",
                        column: x => x.familyId,
                        principalTable: "Families",
                        principalColumn: "familyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_familyId",
                table: "Addresses",
                column: "familyId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyBabyGifts_babyGiftId",
                table: "FamilyBabyGifts",
                column: "babyGiftId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyBabyGifts_familyId",
                table: "FamilyBabyGifts",
                column: "familyId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_familyId",
                table: "Person",
                column: "familyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "FamilyBabyGifts");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "BabyGifts");

            migrationBuilder.DropTable(
                name: "Families");
        }
    }
}
