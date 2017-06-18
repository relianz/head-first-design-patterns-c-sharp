using System.Collections.Generic;           // List.
using WeatherStation.Interfaces;

namespace WeatherStation.Implementations
{
    public class WeatherData: ISubject
    {
        private List<IObserver> observers;

        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();

        } // ctor

        #region ISubbject
        
        public void RegisterObserver( IObserver o )
        {
            observers.Add(o);

        } // ISubject.RegisterObserver

        public void RemoveObserver( IObserver o )
        {
            int i = observers.IndexOf(o);
            if( i >= 0 )
            {
                observers.Remove(o);

            } // observer is on list of observers.

        } // ISubject.RemoveObserver

        public void NotifyObservers()
        {
            foreach( IObserver o in observers )
            {
                o.Update(temperature, humidity, pressure);

            } // for all observers on list.

        } // ISubject.NotifyObservers

        #endregion

        #region Measurements

        public void measurementsChanged()
        {
            NotifyObservers();

        } // measurementsChanged

        public void setMeasurements( float temperature, float humidity, float pressure )
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();

        } // setMeasurements

        #endregion

    } // WeatherData

} // WeatherStation.Implementations
