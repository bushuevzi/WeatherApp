using System;
using System.Linq;
using System.Net.Http;
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

        private City GetCityInfo(string city)
        {
            return DbCtx.Cities.FirstOrDefault(c => string.Equals(c.Name,city, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Получение погоды для отображения на фронте
        /// </summary>
        /// <param name="city">Наименование города</param>
        /// <returns></returns>
        public Weather GetWheatherForView(string city)
        {
            // Получить запрос у стороннего поставщика погоды (например Яндекс)

            // Преобразовать данные к нужному формату для представления

            // Сохраняем запрос в базу

            // Отдаем результат.
            throw new System.NotImplementedException();
        }
    }
}