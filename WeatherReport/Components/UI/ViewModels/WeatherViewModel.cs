using PropertyChanged;
using System.Windows.Input;
using WeatherReport.Components.Domain.Entities;
using WeatherReport.Components.Domain.Helpers;
using WeatherReport.Components.Domain.Repositories;
using WeatherReport.Components.Infrastructure.WeatherApi;

namespace WeatherReport.Components.UI.ViewModels;

[AddINotifyPropertyChangedInterface]
internal sealed class WeatherViewModel
{
    private IWeatherRepository _weatherInfra;
    public WeatherData WeatherData { get; set; }
    public string PlaceName { get; set; }
    public bool IsMainVisible { get; set; } = false;
    public bool IsLoading { get; set; } = false;
    

    public WeatherViewModel() : this(new WeatherApi())
    {
    }

    public WeatherViewModel(IWeatherRepository weatherInfra)
    {
        _weatherInfra = weatherInfra;
    }

    public ICommand SearchCommand =>
        new Command(async (searchText) =>
        {
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
            {
                var address = searchText.ToString();
                if (address == string.Empty)
                {
                    ShowAlert();
                    return;
                }

                // 検索された地名の string を Location 型に変換
                var location = await GeoHelper.GetCoordinatesAsync(address);
                if (location == null)
                {
                    ShowAlert();
                    return;
                }

                PlaceName = char.ToUpper(address[0]) + address.Substring(1);

                IsLoading = true;
                // Location 型の地名を渡して天気の情報を取得、WeatherData フィールドに格納
                WeatherData = await _weatherInfra.GetWeather(location);

                IsMainVisible = true;
                IsLoading = false;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Oops!", "Sry, check your network first", "OK");
            }
        });

    private void ShowAlert() => App.Current.MainPage.DisplayAlert("Oops!", "Sry, correct city name plz", "OK");
}
