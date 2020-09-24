using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherStation : IWeatherStation
    {
        private int _temperature;
        private int _dampness;
        private List<IObserver> _observers;

        public WeatherStation()
        {
            _temperature = 25;
            _dampness = 45;
            _observers = new List<IObserver>();
        }
        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }

        public int GetTemperature()
        {
            return _temperature;
        }

        public void SetDampness(int dampness)
        {
            _dampness = dampness;
            NotifyObservers();
        }

        public int GetDampness()
        {
            return _dampness;
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
                observer.Action();
        }
    }
}