using WeatherApp.Models;

namespace WeatherApp.Services.AppService
{
    /// <summary>
    /// Главный сервис приложения
    /// </summary>
    public class AppService : IAppService
    {
        private City GetCityInfo(string city)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Получение погоды для отображения на фронте
        /// </summary>
        /// <param name="city">Наименование города</param>
        /// <returns></returns>
        public Weather GetWheatherForView(string city)
        {
            throw new System.NotImplementedException();
        }
    }
}