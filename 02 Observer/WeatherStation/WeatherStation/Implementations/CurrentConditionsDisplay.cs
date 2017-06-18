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

using WeatherStation.Interfaces;
using static System.Console;

namespace WeatherStation.Implementations
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;

        private ISubject weatherData;

        public CurrentConditionsDisplay( ISubject weatherData )
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);

        } // ctor

        #region IObserver

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            Display();

        } // Update

        #endregion

        #region IDisplayElement
        
        public void Display()
        {
            WriteLine("Aktuelle Wetterbedingungen: {0} °C Temperatur - {1} % Luftfeuchtigkeit", temperature, humidity);

        } // Display

        #endregion

    } // class CurrentConditionsDisplay

} // namespace WeatherStation.Implementations
