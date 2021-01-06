using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FuelStation.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    PlanetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.PlanetId);
                });

            migrationBuilder.CreateTable(
                name: "SpaceShips",
                columns: table => new
                {
                    SpaceShipId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaceShips", x => x.SpaceShipId);
                });

            migrationBuilder.CreateTable(
                name: "PlanetSpaceShipFuelType",
                columns: table => new
                {
                    PlanetSpaceShipFuelTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlanetId = table.Column<int>(nullable: false),
                    SpaceShipId = table.Column<int>(nullable: true),
                    FuelTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetSpaceShipFuelType", x => x.PlanetSpaceShipFuelTypeId);
                    table.ForeignKey(
                        name: "FK_PlanetSpaceShipFuelType_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "FuelTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanetSpaceShipFuelType_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanetSpaceShipFuelType_SpaceShips_SpaceShipId",
                        column: x => x.SpaceShipId,
                        principalTable: "SpaceShips",
                        principalColumn: "SpaceShipId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanetSpaceShipFuelType_FuelTypeId",
                table: "PlanetSpaceShipFuelType",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetSpaceShipFuelType_PlanetId",
                table: "PlanetSpaceShipFuelType",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetSpaceShipFuelType_SpaceShipId",
                table: "PlanetSpaceShipFuelType",
                column: "SpaceShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanetSpaceShipFuelType");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "SpaceShips");
        }
    }
}
