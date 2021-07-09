using System;

namespace WeatherStation 
{
    public class WeatherEventArgs
    {
        private readonly double temperature;
        private readonly double humidity;
        private readonly double pressure;

        public WeatherEventArgs(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity >= 0 && humidity <= 100 ? humidity : throw new ArgumentOutOfRangeException(nameof(humidity));
            this.pressure = pressure > 0 ? pressure : throw new ArgumentOutOfRangeException(nameof(pressure));
        }

        public double Temperature { get => this.temperature; }
        public double Humidity { get => this.humidity; }
        public double Pressure { get => this.pressure; }
    }
}
