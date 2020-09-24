using System;

namespace WeatherStation
{
    public class TemperatureObserver : IObserver
    {
        private readonly IWeatherStation _weatherStation;

        public TemperatureObserver(IWeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Action()
        {
            if(_weatherStation.GetTemperature() > 30)
                Console.WriteLine("Turn on air conditioner");
            else if(_weatherStation.GetTemperature() < 5)
                Console.WriteLine("Turn on heater");
            else
                Console.WriteLine("Do nothing");
        }
    }
}