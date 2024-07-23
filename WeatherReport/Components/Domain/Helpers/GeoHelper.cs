namespace WeatherReport.Components.Domain.Helpers;

internal static class GeoHelper
{
    public static async Task<Location> GetCoordinatesAsync(string address)
    {
        IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);
        Location location = locations?.FirstOrDefault();

        if (location == null) return null;
        // Console.WriteLine($"Latitude:{location.Latitude}, Longitude:{location.Longitude}, Altitude: {location.Altitude}");
        return location;
    }
}
