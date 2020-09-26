namespace WeatherStation
{
    public interface IWeather
    {
        int Temperature { get; set; }
        int Dampness { get; set; }
    }
}