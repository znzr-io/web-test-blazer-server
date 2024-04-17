using System;
using web_test_blazer_server.Data;



namespace web_test_blazer_server.Pages
{
	public partial class FetchData  
	{
        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        }

        public FetchData()
		{
		}
	}
}