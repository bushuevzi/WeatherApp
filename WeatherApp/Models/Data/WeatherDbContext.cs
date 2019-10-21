using System;
using Microsoft.EntityFrameworkCore;

namespace WeatherApp.Models
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        #region Таблицы
        public DbSet<City> Cities { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<WeatherHystory> WeatherHystories { get; set; } 
        #endregion

        #region Сидинг данных

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City { CityId = new Guid(), Name = "Krasnodar", NameRu = "Краснодар", Lat = 45.040095m, Lon = 38.977030m });
            modelBuilder.Entity<City>().HasData(new City { CityId = new Guid(), Name = "Moscow", NameRu = "Москва", Lat = 55.753215m, Lon = 37.622504m });
            modelBuilder.Entity<City>().HasData(new City { CityId = new Guid(), Name = "Orengurg", NameRu = "Оренбург", Lat = 51.768199m, Lon = 55.096955m });
            modelBuilder.Entity<City>().HasData(new City { CityId = new Guid(), Name = "St.Peretburg", NameRu = "Санкт-Петербург", Lat = 59.939095m, Lon = 30.315868m });
            modelBuilder.Entity<City>().HasData(new City { CityId = new Guid(), Name = "Kaliningrad", NameRu = "Калининград", Lat = 54.710454m, Lon = 20.512733m });
        }

        #endregion
    }
}