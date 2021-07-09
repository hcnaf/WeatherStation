using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new WeatherStation();
            var weatherReport = new CurrentConditionReprot();
            station.Register(weatherReport);

            station.weatherData.ChangeWeather(station.weatherData, new WeatherArgs(31.05, 56.6, 760.3));
        }
    }
}
