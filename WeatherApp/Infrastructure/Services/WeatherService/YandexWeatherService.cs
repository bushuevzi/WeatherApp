using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WeatherApp.Configurations;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    /// <summary>
    /// Сервис получения информации о погоде
    /// </summary>
    public class YandexWeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<YandexWeatherConfig> _yandexWeatherConfig;

        #region Внедрение зависимостей
        public YandexWeatherService(HttpClient httpClient,
            IOptions<YandexWeatherConfig> yandexWeatherConfig)
        {
            _httpClient = httpClient;
            _yandexWeatherConfig = yandexWeatherConfig;
        }
        #endregion

        /// <summary>
        /// Запрос погоды в тороннем API
        /// </summary>
        /// <param name="city">Информация о городе</param>
        /// <returns></returns>
        public Responce RequestWeather(City city)
        {
            // Отправляем запрос
            var responceContent = SendRequestAsync(city).Result.Content.ReadAsStringAsync().Result;

            // Получаем и десериализуем запрос
            var result = JsonConvert.DeserializeObject<Responce>(responceContent);

            return result;
        }

        /// <summary>
        /// Метод отправки запроса в Яндекс погода
        /// </summary>
        /// <param name="request">Тело запроса</param>
        /// <param name="apiKey">ApiKey</param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> SendRequestAsync(City city)
        {
            // Добавляем заголовок авторизации
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-Yandex-API-Key", _yandexWeatherConfig.Value.Url);

            // Строим URL
            var builder = new UriBuilder(_yandexWeatherConfig.Value.Url);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["lat"] = city.Lat.ToString();
            query["lon"] = city.Lon.ToString();
            builder.Query = query.ToString();
            string url = builder.ToString();

            // Выполняем запрос
            var response = await _httpClient.GetAsync(url);

            return response;
        }
    }
}