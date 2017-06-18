//
//    Head First Design Patterns - C# Examples (HFDP/C#)
//
//    Copyright (C) 2017 Markus A. Stulle (markus@stulle.zone)
//
//	  This file is part of HFDP/C#.   
//
//    HFDP/C# is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    HFDP/C# is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with HFDP/C#. If not, see <http://www.gnu.org/licenses/>.
//	

using System;                           // IObservable, IObserver, IDisposable.
using System.Collections.Generic;       // List.

namespace Advanced_WeatherStation.Implementations
{
    public class WeatherData: IObservable<Measurement>
    {
        private List<IObserver<Measurement>> observers;

        public WeatherData()
        {
            observers = new List<IObserver<Measurement>>();

        } // ctor
        
        public void SetMeasurement(Nullable<Measurement> m)
        {
            foreach (var observer in observers)
            {
                if (!m.HasValue)
                    observer.OnError(new MeasurementUnknownException());
                else
                    observer.OnNext(m.Value);
            }

        } // SetMeasurement

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();

        } // EndTransmission.

        #region IObservable

        public IDisposable Subscribe(IObserver<Measurement> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);

        } // IObservable.Subscribe

        #endregion

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Measurement>> _observers;
            private IObserver<Measurement> _observer;

            public Unsubscriber(List<IObserver<Measurement>> observers, IObserver<Measurement> observer)
            {
                this._observers = observers;
                this._observer  = observer;

            } // ctor

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);

            } // Dispose

        } // internal class Unsubscriber

    } // class WeatherData 

} // namespace Advanced_WeatherStation.Implementations
