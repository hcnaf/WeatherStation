using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class CurrentConditionReprot : IObserver
    {
        public void Update(object sender, WeatherArgs info)
        {
            Console.WriteLine("Weather changed:");
            Console.WriteLine($"Temperature: {info.Temperature}");
            Console.WriteLine($"Humidity: {info.Humidity}");
            Console.WriteLine($"Pressure: {info.Pressure}");
        }
    }
}
