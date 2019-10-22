using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Services.AppService;

namespace WeatherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : Controller
    {
        #region Внедрение зависимостей

        private readonly IAppService _appService;

        public WeatherController(IAppService appService)
        {
            _appService = appService;
        }
        #endregion

        // GET: api/Weather
        [HttpGet]
        public async Task<IActionResult> Get(string city) => Json(await _appService.GetWheatherForView(city));
    }
}
