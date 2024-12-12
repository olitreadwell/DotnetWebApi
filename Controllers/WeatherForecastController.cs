using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApi.Controllers;

// Indicates that this class is an API controller
[ApiController]
// Defines the route for the controller
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // Creates a list of possible weather descriptions
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    // Logger to record information
    private readonly ILogger<WeatherForecastController> _logger;

    // Constructor to setup the logger
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    // This method runs when a GET request is made to the controller
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        // Creates a list of weather forecasts
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            // Sets the date for the forecast to be the current date plus the index as days
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),

            // Sets the temperature to a random number between -20 and 55
            TemperatureC = Random.Shared.Next(-20, 55),

            // Sets the weather description summary to a random value from the Summaries array
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray(); // Converts the list to an array
    }
}
