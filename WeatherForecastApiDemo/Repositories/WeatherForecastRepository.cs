namespace WeatherForecastApiDemo.Repositories
{
	public interface IWeatherForecastRepository
	{
		Task<IEnumerable<WeatherForecast>> GetForecastAsync();
	}
	public class WeatherForecastRepository : IWeatherForecastRepository
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};
		public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
		{
			var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
			return (IEnumerable<WeatherForecast>)Task.FromResult(result);
		}
	}
}
