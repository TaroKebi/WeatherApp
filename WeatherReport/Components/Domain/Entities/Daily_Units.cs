namespace WeatherReport.Components.Domain.Entities;

public sealed class Daily_Units
{
    public Daily_Units(string time, string weather_code, string temperature_2m_max, string temperature_2m_min)
    {
        this.time = time;
        this.weather_code = weather_code;
        this.temperature_2m_max = temperature_2m_max;
        this.temperature_2m_min = temperature_2m_min;
    }

    public string time { get; }
    public string weather_code { get; }
    public string temperature_2m_max { get; }
    public string temperature_2m_min { get; }
}
