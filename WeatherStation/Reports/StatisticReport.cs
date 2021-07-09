using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class StatisticReport
    {
        private readonly List<double> temperatures = new();
        private readonly List<double> humidities = new();
        private readonly List<double> pressures = new();

        public void Update(object sender, WeatherEventArgs info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            this.temperatures.Add(info.Temperature);
            this.humidities.Add(info.Humidity);
            this.pressures.Add(info.Pressure);

            Report();
        }

        private void Report()
        {
            Console.WriteLine("Weather changed, statistics updated:");
            Console.WriteLine($"Average temeprature: {this.temperatures.Average()}");
            Console.WriteLine($"Average humidity: {this.humidities.Average()}");
            Console.WriteLine($"Average pressure: {this.pressures.Average()}");
            Console.WriteLine();
        }
    }
}
