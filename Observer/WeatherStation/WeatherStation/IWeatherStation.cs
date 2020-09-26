using System;

namespace WeatherStation
{
    public interface IWeatherStation
    {
        void SetTemperature(int temperature);
        int GetTemperature();
        void SetDampness(int dampness);
        int GetDampness();

        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(IWeatherStation weatherStation, IWeather weather);
    }
}