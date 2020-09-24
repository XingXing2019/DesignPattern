using System;

namespace WeatherStation
{
    public class DampnessObserver : IObserver
    {
        private readonly IWeatherStation _weatherStation;

        public DampnessObserver(IWeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Action()
        {
            if(_weatherStation.GetDampness() > 50)
                Console.WriteLine("Turn on dryer");
            else if (_weatherStation.GetDampness() < 20)
                Console.WriteLine("Turn on humidifier");
            else
                Console.WriteLine("Do nothing");
        }
    }
}