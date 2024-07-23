namespace WeatherReport.Components.Domain.Exceptions;

internal sealed class IOException : Exception
{
    public IOException(string message) : base(message)
    {
    }
}
