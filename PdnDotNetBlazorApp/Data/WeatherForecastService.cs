namespace PdnDotNetBlazorApp.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Balmy",
            "Bracing",
            "Chilly",
            "Cool",
            "Freezing",
            "Hot",
            "Mild",
            "Scorching",
            "Sweltering",
            "Warm",
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}