using Newtonsoft.Json;

namespace WeatherApp.Models
{
    /// <summary>
    /// Объект содержит информацию о погоде на данный момент
    /// </summary>
    public class Fact
    {
        /// <summary>
        /// Температура (°C).
        /// </summary>
        [JsonProperty(PropertyName = "temp")]
        public decimal Temp { get; set; }

        /// <summary>
        /// Ощущаемая температура (°C).	
        /// </summary>
        [JsonProperty(PropertyName = "feels_like")]
        public decimal FeelsLike { get; set; }

        /// <summary>
        /// Температура воды (°C).Если в городе нет водоема, вернуть null	
        /// </summary>
        [JsonProperty(PropertyName = "temp_water")]
        public decimal? TempWater { get; set; }

        /// <summary>
        /// Код расшифровки погодного описания
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Скорость ветра (в м/с).	
        /// </summary>
        [JsonProperty(PropertyName = "wind_speed")]
        public decimal WindSpeed { get; set; }

        /// <summary>
        /// Скорость порывов ветра (в м/с).	
        /// </summary>
        [JsonProperty(PropertyName = "wind_gust")]
        public decimal WindGust { get; set; }

        /// <summary>
        /// Направление ветра
        /// </summary>
        [JsonProperty(PropertyName = "wind_dir")]
        public string WindDir { get; set; }

        /// <summary>
        /// Давление (в мм рт. ст.).	
        /// </summary>
        [JsonProperty(PropertyName = "pressure_mm")]
        public decimal PressureMm { get; set; }

        /// <summary>
        /// Тип осадков
        /// </summary>
        [JsonProperty(PropertyName = "prec_type")]
        public int PrecType { get; set; }
    }
}