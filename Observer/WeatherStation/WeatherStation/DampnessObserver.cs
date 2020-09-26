using System;

namespace WeatherStation
{
    public class DampnessObserver : IObserver
    {
        public void Action(IWeatherStation weatherStation, IWeather weather)
        {
            if(weatherStation.GetDampness() > 50)
                Console.WriteLine("Turn on dryer");
            else if (weatherStation.GetDampness() < 20)
                Console.WriteLine("Turn on humidifier");
            else
                Console.WriteLine("Do nothing");
        }
    }
}