using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class WeatherStation : IObservable, IObserver
    {
        private List<IObserver> observers = new();
        public WeatherData weatherData { get; private set; }

        public WeatherStation()
        {
            this.weatherData = new WeatherData(this);
        }

        void IObservable.Notify(WeatherArgs info)
        {
            for (int i = 0; i < this.observers.Count; ++i)
            {
                this.observers[i].Update(this, info);
            }
        }

        public void Register(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            this.observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            this.observers.Remove(observer);
        }

        public void Update(object sender, WeatherArgs info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            ((IObservable)this).Notify(info);
        }
    }
}
