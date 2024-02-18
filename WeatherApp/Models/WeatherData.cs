public class WeatherData
{
    public string Location { get; set; }
    public DateTime Time { get; set; }
    public double WindSpeed { get; set; }
    public int Visibility { get; set; }
    public string SkyConditions { get; set; }
    public double TemperatureCelsius { get; set; }
    public double TemperatureFahrenheit { get; set; }
    public double DewPoint { get; set; }
    public double RelativeHumidity { get; set; }
    public double Pressure { get; set; }
}