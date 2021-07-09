namespace WeatherStation
{
    interface IObserver
    {
        void Update(object sender, WeatherArgs info);
    }
}