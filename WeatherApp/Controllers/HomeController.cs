﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherApp.Models;
using WeatherApp.Services.AppService;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        #region Внедрение зависимостей
        private readonly IAppService _appService;

        public HomeController(IAppService appService)
        {
            _appService = appService;
        } 
        #endregion

        public async Task<IActionResult> Index(string id)
        {
            // Если значение города не передано Get запросом
            if(string.IsNullOrEmpty(id))
                return View();

            // Если город передан получаем погоду
            var weather = await _appService.GetWheatherForView(id);
            return View("Index", weather);
        }

        /// <summary>
        /// Получение погоды из из базы по ее id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public IActionResult GetJson(Guid id) => Json(_appService.GetWeatherById(id));

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
