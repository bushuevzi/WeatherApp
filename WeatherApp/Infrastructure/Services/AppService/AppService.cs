using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services.AppService
{
    /// <summary>
    /// Главный сервис приложения
    /// </summary>
    public class AppService : BaseService, IAppService
    {
        private readonly IWeatherService _weatherService;

        #region Внедрение зависимостей
        public AppService(WeatherDbContext dbCtx,
            IWeatherService weatherService)
        :base(dbCtx)
        {
            _weatherService = weatherService;
        }

        #endregion

        /// <summary>
        /// Получение города из базы
        /// </summary>
        /// <param name="city">Наименование города по английски</param>
        /// <returns></returns>
        private City GetCityInfo(string city) => DbCtx.Cities.FirstOrDefault(c => c.Name.Equals(city));

        /// <summary>
        /// Сохраняем историю погоды в базу
        /// </summary>
        /// <param name="city">Информация о городе</param>
        /// <param name="weather">Погода</param>
        /// <param name="timestamp">Время запроса в формате Unix timestamp</param>
        private void SaveWeatherHistory(City city, Weather weather, double timestamp)
        {
            DbCtx.WeatherHystories.Add(new WeatherHistory
            {
                City = city,
                Weather = weather,
                // Получаем время из Unix timestamp
                WeatherDateTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(timestamp)
            });
            DbCtx.SaveChanges();
        }

        /// <summary>
        /// Получение погоды по Id
        /// </summary>
        /// <param name="id">Идентификатор погоды в БД</param>
        /// <returns></returns>
        public Weather GetWeatherById(Guid id) => DbCtx.Weathers.FirstOrDefault(w => w.WeatherId == id);

        /// <summary>
        /// Получение погоды для отображения на фронте
        /// </summary>
        /// <param name="city">Наименование города</param>
        /// <returns></returns>
        public async Task<Weather> GetWheatherForView(string city)
        {
            // Получить информацию о городе
            var cityInfo = GetCityInfo(city);

            // Получить погоду у стороннего поставщика погоды (например Яндекс)
            var responce = await _weatherService.RequestWeather(cityInfo);
            var weatherResponce = responce.Fact;

            // Преобразовать данные к нужному формату для представления (подстановка в некоторые значения кирилицы)
            var weather = new Weather
            {
                Temp = weatherResponce.Temp,
                FeelsLike = weatherResponce.FeelsLike,
                TempWater = weatherResponce.TempWater,
                Condition = Dictionaries.Conditions[weatherResponce.Condition],
                WindSpeed = weatherResponce.WindSpeed,
                WindGust = weatherResponce.WindGust,
                WindDir = Dictionaries.WindDirection[weatherResponce.WindDir],
                PressureMm = weatherResponce.PressureMm,
                PrecType = Dictionaries.PrecipitationType[weatherResponce.PrecType]
            };

            // Сохраняем запрос в базу
            SaveWeatherHistory(cityInfo, weather, responce.Now);

            // Отдаем результат.
            return weather;
        }
    }
}