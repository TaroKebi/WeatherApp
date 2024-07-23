namespace WeatherReport.Components.Domain.ValueObjects;

internal sealed class CurrentDataDate
{
    public CurrentDataDate(DateTime value)
    {
        Value = value;
    }

    public DateTime Value { get; }
    public string DisplayValue { get => "Weather today : " + Value.ToString("MMMM dd, yyyy"); }
}
