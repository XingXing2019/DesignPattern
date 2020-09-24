using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherStation = new WeatherStation();
            var temperatureObserver = new TemperatureObserver(weatherStation);
            var dampnessObserver = new DampnessObserver(weatherStation);

            weatherStation.AddObserver(temperatureObserver);
            weatherStation.AddObserver(dampnessObserver);

            weatherStation.SetTemperature(35);
            weatherStation.SetDampness(60);
        }
    }
}
