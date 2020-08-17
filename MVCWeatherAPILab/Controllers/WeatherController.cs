using System;
using MVCWeatherAPILab.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MVCWeatherAPILab.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _weatherService.GetAll();
            model.Currentobservation.Weatherimage = model.Currentobservation.Weatherimage.Insert(0, @"http://forecast.weather.gov/newimages/medium/");
            return View(model);
        }
    }
}
