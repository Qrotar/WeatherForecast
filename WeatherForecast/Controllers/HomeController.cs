using System.Diagnostics;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WeatherForecast.Data;
using WeatherForecast.Models;
using WeatherForecast.Helper;

namespace WeatherForecast.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public async Task<IActionResult> Forecast()
    {
        var weatherData = await ApiData.GetWeatherForecast(_configuration.GetValue<string>("OpenWeatherMapAPI:BaseURL"), _configuration.GetValue<string>("OpenWeatherMapAPI:AuthKey"));

        return View(weatherData);
    }

    public async Task<IActionResult> Today()
    {
        var weatherData = await ApiData.GetWeatherToday(_configuration.GetValue<string>("OpenWeatherMapAPI:BaseURL"), _configuration.GetValue<string>("OpenWeatherMapAPI:AuthKey"));

        return View(weatherData);
    }





    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

