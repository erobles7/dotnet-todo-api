using TodoApi.Dto;

namespace TodoApi.Interfaces;

public interface IWeatherService
{
    IEnumerable<WeatherForecastDto> GetWeatherForecasts();
}
