using System;

namespace WeatherStation
{
    public class TemperatureObserver : IObserver
    {
        public void Action(IWeatherStation weatherStation, IWeather weather)
        {
            if(weather.Temperature > 30)
                Console.WriteLine("Turn on air conditioner");
            else if(weather.Temperature < 5)
                Console.WriteLine("Turn on heater");
            else
                Console.WriteLine("Do nothing");
        }
    }
}