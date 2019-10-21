using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("3305e433-bf0a-42d1-9833-04ac5ad0870e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("4f2d1652-c199-43f6-85fa-e1f3735024e0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("7e354fdb-3d9e-424e-a30d-9051566268fe"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("cadf1b44-eb8f-4f2c-9ef6-c10804348b58"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("e871d41d-14c2-4511-95e8-b2a6500d91e3"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Lat", "Lon", "Name", "NameRu" },
                values: new object[,]
                {
                    { new Guid("cadf1b44-eb8f-4f2c-9ef6-c10804348b58"), 45.040096282958984, 38.977031707763672, "Krasnodar", "Краснодар" },
                    { new Guid("e871d41d-14c2-4511-95e8-b2a6500d91e3"), 55.753215789794922, 37.622505187988281, "Moscow", "Москва" },
                    { new Guid("7e354fdb-3d9e-424e-a30d-9051566268fe"), 51.768199920654297, 55.096954345703125, "Orengurg", "Оренбург" },
                    { new Guid("4f2d1652-c199-43f6-85fa-e1f3735024e0"), 59.939094543457031, 30.315868377685547, "St.Peretburg", "Санкт-Петербург" },
                    { new Guid("3305e433-bf0a-42d1-9833-04ac5ad0870e"), 54.710453033447266, 20.512733459472656, "Kaliningrad", "Калининград" }
                });
        }
    }
}
