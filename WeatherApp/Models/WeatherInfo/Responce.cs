using Newtonsoft.Json;

namespace WeatherApp.Models
{
    /// <summary>
    /// Ответ на запрос погоды
    /// </summary>
    public class Responce
    {
        /// <summary>
        /// Время сервера в формате Unixtime
        /// </summary>
        [JsonProperty(PropertyName = "now")]
        public decimal Now { get; set; }

        /// <summary>
        /// Время сервера в UTC.
        /// </summary>
        [JsonProperty(PropertyName = "now_dt")]
        public string NowDt { get; set; }

        /// <summary>
        /// Объект фактической информации о погоде
        /// </summary>
        [JsonProperty(PropertyName = "fact")]
        public WeatherResponce Fact { get; set; }
    }
}