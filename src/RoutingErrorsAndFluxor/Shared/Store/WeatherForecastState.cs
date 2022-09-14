using Fluxor;
using RoutingErrorsAndFluxor.Data;

namespace RoutingErrorsAndFluxor.Shared.Store;

[FeatureState]
public class WeatherForecastState
{
	public bool IsLoading { get; set; }

	public IEnumerable<WeatherForecast>? Forecasts { get; set; }

	private WeatherForecastState()
	{ }

	public WeatherForecastState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
	{
		this.IsLoading = isLoading;
		this.Forecasts = forecasts;
	}
}
