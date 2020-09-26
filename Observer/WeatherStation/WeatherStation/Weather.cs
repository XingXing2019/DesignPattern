namespace WeatherStation
{
    public class Weather : IWeather
    {
        public int Temperature { get; set; }
        public int Dampness { get; set; }

        public Weather(int temperature, int dampness)
        {
            Temperature = temperature;
            Dampness = dampness;
        }
    }
}