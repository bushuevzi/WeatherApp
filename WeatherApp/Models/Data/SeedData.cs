using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<WeatherDbContext>();

                // Применяем миграцию к базе
                context.Database.Migrate();

                // Если таблица пуста, то наполняем ее
                if (!context.Cities.Any())
                {
                    context.Cities.AddRange(
                        new City { CityId = Guid.NewGuid(), Name = "Krasnodar", NameRu = "Краснодар", Lat = 45.040095f, Lon = 38.977030f },
                        new City { CityId = Guid.NewGuid(), Name = "Moscow", NameRu = "Москва", Lat = 55.753215f, Lon = 37.622504f },
                        new City { CityId = Guid.NewGuid(), Name = "Orengurg", NameRu = "Оренбург", Lat = 51.768199f, Lon = 55.096955f },
                        new City { CityId = Guid.NewGuid(), Name = "St.Peretburg", NameRu = "Санкт-Петербург", Lat = 59.939095f, Lon = 30.315868f },
                        new City { CityId = Guid.NewGuid(), Name = "Kaliningrad", NameRu = "Калининград", Lat = 54.710454f, Lon = 20.512733f }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}