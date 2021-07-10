using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    /// <summary>
    /// Weather data class, that simulates real implementation.
    /// </summary>
    internal class WeatherData
    {
        /// <summary>
        /// Station, that weather data connected to.
        /// </summary>
        internal WeatherStation station { get; private set; }

        /// <summary>
        /// Initializes weather data object, that is connected to specified station.
        /// </summary>
        /// <param name="station">station to connect to.</param>
        internal WeatherData(WeatherStation station)
        {
            if (station is null)
            {
                throw new ArgumentNullException(nameof(station));
            }

            this.station = station;
        }

        /// <summary>
        /// Changes weather. Only for tests.
        /// </summary>
        /// <param name="info">Weather to set.</param>
        public void ChangeWeather(WeatherEventArgs info)
        {
            station.Notify(info);
        }
    }
}
