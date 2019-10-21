using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NameRu = table.Column<string>(nullable: true),
                    Lat = table.Column<double>(nullable: false),
                    Lon = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    WeatherId = table.Column<Guid>(nullable: false),
                    Temp = table.Column<double>(nullable: false),
                    FeelsLike = table.Column<double>(nullable: false),
                    TempWater = table.Column<double>(nullable: true),
                    Condition = table.Column<string>(nullable: true),
                    WindSpeed = table.Column<double>(nullable: false),
                    WindGust = table.Column<double>(nullable: false),
                    WindDir = table.Column<string>(nullable: true),
                    PressureMm = table.Column<double>(nullable: false),
                    PrecType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.WeatherId);
                });

            migrationBuilder.CreateTable(
                name: "WeatherHystories",
                columns: table => new
                {
                    WeatherHystoryId = table.Column<Guid>(nullable: false),
                    WeatherDateTime = table.Column<DateTime>(nullable: false),
                    CityId = table.Column<Guid>(nullable: true),
                    WeatherId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherHystories", x => x.WeatherHystoryId);
                    table.ForeignKey(
                        name: "FK_WeatherHystories_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherHystories_Weathers_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "Weathers",
                        principalColumn: "WeatherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherHystories_CityId",
                table: "WeatherHystories",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherHystories_WeatherId",
                table: "WeatherHystories",
                column: "WeatherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherHystories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
