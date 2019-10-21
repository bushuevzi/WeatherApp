using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    /// <summary>
    /// Город
    /// </summary>
    public class City
    {
        [Key]
        public Guid CityId { get; set; }

        /// <summary>
        /// Наименование на английском
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Наименование на русском
        /// </summary>
        public string NameRu { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public decimal Lat { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public decimal Lon { get; set; }
    }
}