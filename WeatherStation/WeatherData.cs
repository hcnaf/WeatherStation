using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class WeatherData
    {
        public WeatherStation station { get; private set; }
        public WeatherData(WeatherStation station)
        {
            if (station is null)
            {
                throw new ArgumentNullException(nameof(station));
            }

            this.station = station;
        }

        public void ChangeWeather(object sender, WeatherArgs info)
        {
            station.Update(this, info);
        }
    }
}
