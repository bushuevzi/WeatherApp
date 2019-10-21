using System.Security.AccessControl;

namespace WeatherApp.Models
{
    /// <summary>
    /// Город
    /// </summary>
    public class City
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

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