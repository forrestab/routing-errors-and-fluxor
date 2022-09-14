using Fluxor;
using RoutingErrorsAndFluxor.Data;

namespace RoutingErrorsAndFluxor.Shared.Store;

public class GetWeatherForecasts
{
    public record Action(DateOnly startDate);

    public record Success(IEnumerable<WeatherForecast> Forecasts);

    public class ActionReducer : Reducer<WeatherForecastState, Action>
    {
        public override WeatherForecastState Reduce(WeatherForecastState state, Action action) =>
            new WeatherForecastState(isLoading: true, forecasts: null);
    }

    public class SuccessReducer : Reducer<WeatherForecastState, Success>
    {
        public override WeatherForecastState Reduce(WeatherForecastState state, Success action) =>
            new WeatherForecastState(isLoading: false, action.Forecasts);
    }

    public class Effect : Effect<Action>
    {
        private readonly WeatherForecastService weatherForecastService;

        public Effect(WeatherForecastService weatherForecastService)
        {
            this.weatherForecastService = weatherForecastService;
        }

        public async override Task HandleAsync(Action action, IDispatcher dispatcher)
        {
            // would call the weather service and pass/fail

            dispatcher.Dispatch(new SetAppError.Action("Http error"));
        }
    }
}
