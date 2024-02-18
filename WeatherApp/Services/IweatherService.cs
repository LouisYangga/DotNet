public interface IWeatherService
{
    Task<WeatherData> GetWeatherByCityAsync(string city);
}