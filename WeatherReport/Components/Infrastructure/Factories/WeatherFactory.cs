using WeatherReport.Components.Domain.Repositories;
using WeatherReport.Components.Infrastructure.Api;

namespace WeatherReport.Components.Infrastructure.Factories;

internal static class WeatherFactory
{
    public static IWeatherRepository Create()
    {
        return new WeatherApi();
    }
}
