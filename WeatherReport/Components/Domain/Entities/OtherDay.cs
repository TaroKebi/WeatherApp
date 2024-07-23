namespace WeatherReport.Components.Domain.Entities;

internal sealed class OtherDay
{
    public OtherDay(string time, int weather_code, float temperature_2m_max, float temperature_2m_min)
    {
        this.time = time;
        this.weather_code = weather_code;
        this.temperature_2m_max = temperature_2m_max;
        this.temperature_2m_min = temperature_2m_min;
    }

    public string time { get; set; }
    public int weather_code { get; set; }
    public float temperature_2m_max { get; set; }
    public float temperature_2m_min { get; set; }
}
