using System.Net;
using WeatherForecastApiDemo.Repositories;

namespace WeatherForecastApiDemo.Services
{
	public interface IWeatherForecastService
	{
		Task<IEnumerable<WeatherForecast>> GetForecastAsync();
	}
	public class WeatherForecastService : IWeatherForecastService
	{
		private readonly IWeatherForecastRepository _repository;
		private readonly ILogger<IWeatherForecastService> _logger;
		public WeatherForecastService(IWeatherForecastRepository repository, ILogger<IWeatherForecastService> logger)
		{
			_repository = repository;
			_logger = logger;
		}

		public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
		{
			return await _repository.GetForecastAsync();
		}
	}
}
