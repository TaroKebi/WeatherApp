namespace WeatherReport.Components.Domain.Entities;

internal sealed class Current
{
    public Current(string time, int interval, float temperature_2m, int weather_code, float wind_speed_10m, int wind_direction_10m)
    {
        this.time = time;
        this.interval = interval;
        this.temperature_2m = temperature_2m;
        this.weather_code = weather_code;
        this.wind_speed_10m = wind_speed_10m;
        this.wind_direction_10m = wind_direction_10m;
    }

    public string time { get; }
    public int interval { get; }
    public float temperature_2m { get; }
    public int weather_code { get; }
    public float wind_speed_10m { get; }
    public int wind_direction_10m { get; }
}