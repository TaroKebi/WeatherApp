using WeatherReport.Components.Domain.Entities;

namespace WeatherReport.Components.Domain.Repositories;

internal interface IWeatherRepository
{
    Task<WeatherData> GetWeather(Location location);
}
