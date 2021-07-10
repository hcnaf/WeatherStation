using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    /// <summary>
    /// Weather station.
    /// </summary>
    public class WeatherStation
    {
        /// <summary>
        /// Weather data. Is internal only for simmulating changing weather.
        /// </summary>
        internal WeatherData weatherData { get; private set; }

        /// <summary>
        /// Initializes weather station object and connects it to weather data.
        /// </summary>
        public WeatherStation()
        {
            this.weatherData = new WeatherData(this);
        }

        /// <summary>
        /// Is raised whenever the weather is changed.
        /// </summary>
        public event EventHandler<WeatherEventArgs> Weather = delegate { };

        /// <summary>
        /// Notifies all Weather subscribers.
        /// </summary>
        /// <param name="info"></param>
        internal void Notify(WeatherEventArgs info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            this.Weather(this, info);
        }
    }
}
