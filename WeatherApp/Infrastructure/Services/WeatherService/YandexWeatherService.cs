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
        public async Task<Responce> RequestWeather(City city)
        {
            // Отправляем запрос и получаем результат асинхронно
            var responce = await SendRequestAsync(city);
            var responceContent = await responce.Content.ReadAsStringAsync();

            // Получаем и десериализуем запрос
            return JsonConvert.DeserializeObject<Responce>(responceContent);
        }

        /// <summary>
        /// Метод отправки запроса в Яндекс погода
        /// </summary>
        /// <param name="city">Информация о городе</param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> SendRequestAsync(City city)
        {
            // Добавляем заголовок авторизации
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-Yandex-API-Key", _yandexWeatherConfig.Value.ApiKey);

            // Строим URL
            var builder = new UriBuilder(_yandexWeatherConfig.Value.Url);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["lat"] = city.Lat.ToString();
            query["lon"] = city.Lon.ToString();
            builder.Query = query.ToString();
            string url = builder.ToString();

            // Выполняем запрос
            return await _httpClient.GetAsync(url);
        }
    }
}