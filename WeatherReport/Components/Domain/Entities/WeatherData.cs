using System.Collections.ObjectModel;
using WeatherReport.Components.Domain.ValueObjects;

namespace WeatherReport.Components.Domain.Entities;

internal sealed class WeatherData
{
    public WeatherData(float latitude, float longitude, float generationtime_ms, int utc_offset_seconds, string timezone, string timezone_abbreviation, float elevation, Current_Units current_units, Current current, Daily_Units daily_units, Daily daily)
    {
        this.latitude = latitude;
        this.longitude = longitude;
        this.generationtime_ms = generationtime_ms;
        this.utc_offset_seconds = utc_offset_seconds;
        this.timezone = timezone;
        this.timezone_abbreviation = timezone_abbreviation;
        this.elevation = elevation;
        this.current_units = current_units;
        this.current = current;
        this.daily_units = daily_units;
        this.daily = daily;

        this.CurrentDataDate = new CurrentDataDate(Convert.ToDateTime(current.time)).DisplayValue;
    }

    public float latitude { get; }
    public float longitude { get; }
    public float generationtime_ms { get; }
    public int utc_offset_seconds { get; }
    public string timezone { get; }
    public string timezone_abbreviation { get; }
    public float elevation { get; }
    public Current_Units current_units { get; }
    public Current current { get; }
    public Daily_Units daily_units { get; }
    public Daily daily { get; }

    public string PlaceName { get; }
    public string CurrentDataDate { get; }

    public ObservableCollection<OtherDay> OtherDay { get; set; } = new();
}
