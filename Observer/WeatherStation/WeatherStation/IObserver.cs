namespace WeatherStation
{
    public interface IObserver
    {
        void Action(IWeatherStation weatherStation, IWeather weather);
    }
}