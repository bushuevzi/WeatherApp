using WeatherApp.Models;

namespace WeatherApp.Services
{
    /// <summary>
    /// Базовый тип сервиса
    /// </summary>
    public abstract class BaseService
    {
        #region Внедрение зависимостей
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        protected readonly WeatherDbContext DbCtx;

        protected BaseService(WeatherDbContext dbContext)
        {
            DbCtx = dbContext;
        }
        #endregion
    }
}