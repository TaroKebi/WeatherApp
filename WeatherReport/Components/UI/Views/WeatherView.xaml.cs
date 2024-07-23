using WeatherReport.Components.UI.ViewModels;

namespace WeatherReport.Components.UI.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
		BindingContext = new WeatherViewModel();
	}

    private async void SearchButtonPressed(object sender, EventArgs e)
    {
		var searchBar = sender as SearchBar;
		if (searchBar == null) return;
        if (searchBar.IsSoftInputShowing()) await searchBar.HideSoftInputAsync(CancellationToken.None);
    }
}