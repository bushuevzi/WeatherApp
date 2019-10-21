using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherApp.Configurations;
using WeatherApp.Models;
using WeatherApp.Services;
using WeatherApp.Services.AppService;

namespace WeatherApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Строка подключения к БД
            string connection = Configuration.GetConnectionString("DefaultConnection");

            #region Внедрение зависимостей
            services.AddControllersWithViews();
            services.AddScoped<IAppService, AppService>();
            services.AddScoped<IWeatherService, YandexWeatherService>();
            // Добавляем сервис контекста БД
            services.AddDbContext<WeatherDbContext>(options =>
                options.UseSqlServer(connection));
            
            services.AddHttpClient<IWeatherService, YandexWeatherService>();

            // Десереализуем конфигурацию для подключения к сервису
            services.Configure<YandexWeatherConfig>(Configuration.GetSection("YandexWeatherConfig"));

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
