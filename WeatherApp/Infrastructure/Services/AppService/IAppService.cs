using System;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services.AppService
{
    /// <summary>
    /// Главный сервис приложения
    /// </summary>
    public interface IAppService
    {
        /// <summary>
        /// Получение погоды для отображения на фронте
        /// </summary>
        /// <param name="city">Наименование города</param>
        /// <returns></returns>
        Task<Weather> GetWheatherForView(string city);

        /// <summary>
        /// Получение погоды по Id
        /// </summary>
        /// <param name="id">Идентификатор погоды в БД</param>
        /// <returns></returns>
        string GetWeatherById(Guid id);
    }
}