using WeatherApp.Models;

namespace WeatherApp.Services
{
    /// <summary>
    /// Сервис получения информации о погоде
    /// </summary>
    public class YandexWeatherService : IWeatherService
    {
        /// <summary>
        /// Запрос погоды в тороннем API
        /// </summary>
        /// <param name="city">Информация о городе</param>
        /// <returns></returns>
        public Responce RequestWeather(City city)
        {
            throw new System.NotImplementedException();
        }
    }
}