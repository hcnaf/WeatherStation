using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    /// <summary>
    /// Current condition reporter.
    /// </summary>
    public class CurrentConditionReprot
    {
        /// <summary>
        /// Shows current weather.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="info">Information about weather.</param>
        public void Update(object sender, WeatherEventArgs info)
        {
            Console.WriteLine("Weather changed:");
            Console.WriteLine($"Temperature: {info.Temperature}");
            Console.WriteLine($"Humidity: {info.Humidity}");
            Console.WriteLine($"Pressure: {info.Pressure}");
            Console.WriteLine();
        }
    }
}
