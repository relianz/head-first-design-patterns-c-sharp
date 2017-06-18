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

using System;                   // IObserver
using static System.Console;

namespace Advanced_WeatherStation.Implementations
{   
    public class CurrentConditionsDisplay: IObserver<Measurement>
    {
        private IDisposable unsubscriber;
        private string name;

        public CurrentConditionsDisplay( string name )
        {
            this.name = name;

        } // ctor.

        public string Name
        {
            get {
                return this.name;
            }

        } // Name

        public virtual void Subscribe( IObservable<Measurement> provider )
        {
            if( provider != null )
                unsubscriber = provider.Subscribe( this );

        } // Subscribe

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();

        } // Unsubscribe

        #region IObserver

        public virtual void OnCompleted()
        {
            WriteLine("The observable has finished the transmission of data to the observer {0}", this.Name);            
            this.Unsubscribe();

        } // IObserver.OnCompleted

        public virtual void OnError(Exception e)
        {
            WriteLine("{0}: Exception of type <{1}> while observing measurements", this.Name, e.GetType().ToString());            

        } // IObserver.OnError

        public virtual void OnNext(Measurement m)
        {
            WriteLine("{0} / Current weather observation: {1} °C Temperature - {2} % Humidity", this.Name, m.Temperature, m.Humidity);           
            
        } // IObserver.OnNext

        #endregion

    } // class CurrentConditionsDisplay

} // namespace WeatherStation.Implementations
