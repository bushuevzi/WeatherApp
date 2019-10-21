using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    /// <summary>
    /// Сервис получения информации о погоде
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Запрос погоды в тороннем API
        /// </summary>
        /// <param name="city">Информация о городе</param>
        /// <returns></returns>
        Task<Responce> RequestWeather(City city);
    }
}