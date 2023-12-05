
using Weather_APP.Services;

namespace Weather_APP;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		var result = await ApiService.GetWeather(24.1469, 120.6839);
		LblCity.Text = result.city.name;
		LblWeatherDescription.Text = result.list[0].weather[0].description;
		LblTemperature.Text = result.list[0].main.temperature + "¡CC";
		LblHumidity.Text = result.list[0].main.humidity + "%";
		LblWind.Text = result.list[0].wind.speed + "km/h";
		ImgWeatherIcon.Source = result.list[0].weather[0].customIcon;
	}
}