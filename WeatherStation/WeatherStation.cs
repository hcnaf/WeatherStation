using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class WeatherStation
    {
        public WeatherData weatherData { get; private set; }

        public WeatherStation()
        {
            this.weatherData = new WeatherData(this);
        }

        public event EventHandler<WeatherEventArgs> Weather = delegate { };

        public void Notify(WeatherEventArgs info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            this.Weather(this, info);
        }
    }
}
