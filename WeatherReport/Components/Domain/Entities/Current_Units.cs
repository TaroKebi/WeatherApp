namespace WeatherReport.Components.Domain.Entities;

internal sealed class Current_Units
{
    public Current_Units(string time, string interval, string temperature_2m, string weather_code, string wind_speed_10m, string wind_direction_10m)
    {
        this.time = time;
        this.interval = interval;
        this.temperature_2m = temperature_2m;
        this.weather_code = weather_code;
        this.wind_speed_10m = wind_speed_10m;
        this.wind_direction_10m = wind_direction_10m;
    }

    public string time { get; }
    public string interval { get; }
    public string temperature_2m { get; }
    public string weather_code { get; }
    public string wind_speed_10m { get; }
    public string wind_direction_10m { get; }
}
