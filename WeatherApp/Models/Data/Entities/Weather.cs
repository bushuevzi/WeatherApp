using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    /// <summary>
    /// Объект содержит информацию о погоде на данный момент
    /// </summary>
    public class Weather
    {
        [Key]
        public Guid WeatherId { get; set; }

        /// <summary>
        /// Температура (°C).
        /// </summary>
        public decimal Temp { get; set; }

        /// <summary>
        /// Ощущаемая температура (°C).	
        /// </summary>
        public decimal FeelsLike { get; set; }

        /// <summary>
        /// Температура воды (°C).Если в городе нет водоема, вернуть null	
        /// </summary>
        public decimal? TempWater { get; set; }

        /// <summary>
        /// Код расшифровки погодного описания
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Скорость ветра (в м/с).	
        /// </summary>
        public decimal WindSpeed { get; set; }

        /// <summary>
        /// Скорость порывов ветра (в м/с).	
        /// </summary>
        public decimal WindGust { get; set; }

        /// <summary>
        /// Направление ветра
        /// </summary>
        public string WindDir { get; set; }

        /// <summary>
        /// Давление (в мм рт. ст.).	
        /// </summary>
        public decimal PressureMm { get; set; }

        /// <summary>
        /// Тип осадков
        /// </summary>
        public string PrecType { get; set; }
    }
}