using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherArgs
    {
        private readonly double temperature;
        private readonly double humidity;
        private readonly double pressure;

        public WeatherArgs(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public double Temperature { get => this.temperature; }
        public double Humidity { get => this.humidity; }
        public double Pressure { get => this.pressure; }
    }
}
