using System;
using Microsoft.EntityFrameworkCore;

namespace WeatherApp.Models
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
            : base(options)
        {
        }

        #region Таблицы
        public DbSet<City> Cities { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<WeatherHistory> WeatherHystories { get; set; } 
        #endregion
    }
}