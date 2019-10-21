namespace WeatherApp.Configurations
{
    public class YandexWeatherConfig
    {
        /// <summary>
        /// Ссылка на сервис Яндекс погода
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Ключ доступа к сервису
        /// </summary>
        public string ApiKey { get; set; }
    }
}