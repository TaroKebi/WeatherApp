using System.Diagnostics;
using System.Text.Json;
using WeatherReport.Components.Domain.Entities;
using WeatherReport.Components.Domain.Repositories;

namespace WeatherReport.Components.Infrastructure.WeatherApi;

internal sealed class WeatherApi : IWeatherRepository
{
    private HttpClient _client;

    public WeatherApi()
    {
        _client = new HttpClient();
    }

    public async Task<WeatherData> GetWeather(Location location)
    {
        var url = $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,weather_code,wind_speed_10m,wind_direction_10m&daily=weather_code,temperature_2m_max,temperature_2m_min&timezone=Asia%2FTokyo";
        Debug.WriteLine(url);

        var response = await _client.GetAsync(url);
        WeatherData weatherData;
        if (response.IsSuccessStatusCode)
        {
            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
                weatherData = data;

                for (int i = 0; i < weatherData.daily.time.Length; i++)
                {
                    var time = weatherData.daily.time[i];
                    var weather_code = weatherData.daily.weather_code[i];
                    var temperature_2m_max = weatherData.daily.temperature_2m_max[i];
                    var temperature_2m_min = weatherData.daily.temperature_2m_min[i];
                    var tomorrow = new OtherDay(time, weather_code, temperature_2m_max, temperature_2m_min);

                    weatherData.OtherDay.Add(tomorrow);
                }
            }
            return weatherData;
        }
        // 例外処理を書くこと
        else
        {
            App.Current.MainPage.DisplayAlert("Oops!", "Sry, check internet connection plz", "OK");
            return null;
        }
    }
}
