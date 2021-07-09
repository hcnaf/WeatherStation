using System;

namespace WeatherStation
{
    class Program
    {
        static void Main()
        {
            var station = new WeatherStation();

            var currentWeatherReport = new CurrentConditionReprot();
            station.Weather += currentWeatherReport.Update;

            var statisticReport = new StatisticReport();
            station.Weather += statisticReport.Update;

            station.weatherData.ChangeWeather(new WeatherEventArgs(31.05, 56.6, 760.3));
            station.weatherData.ChangeWeather(new WeatherEventArgs(28.9, 43.6, 751.3));
        }
    }
}
