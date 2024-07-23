using WeatherReport.Components.UI.Views;

namespace WeatherReport;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new WeatherView();
    }
}
