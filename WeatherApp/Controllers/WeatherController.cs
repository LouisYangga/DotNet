using Microsoft.AspNetCore.Mvc;

public class WeatherController : Controller
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("{city}")] // Route parameter for city name
    public async Task<IActionResult> GetWeatherByCity(string city)
    {
        try
        {
            var weatherData = await _weatherService.GetWeatherByCityAsync(city);
            return Ok(weatherData);
        }
        catch (Exception ex)
        {
            // Handle exception
            return StatusCode(500, "Error retrieving weather data.");
        }
    }
}
//Mock Integration
// public class WeatherController : Controller
// {
//     private readonly IWeatherService _weatherService;

//     public WeatherController(IWeatherService weatherService)
//     {
//         _weatherService = weatherService;
//     }

//     [HttpGet("{city}")] // Route parameter for city name
//     public async Task<IActionResult> GetWeatherByCity(string city)
//     {
//         try
//         {
//             var weatherData = await _weatherService.GetMockWeatherDataByCityAsync(city);
//             return Ok(weatherData);
//         }
//         catch (Exception ex)
//         {
//             // Handle exception
//             return StatusCode(500, "Error retrieving mock weather data.");
//         }
//     }
// }