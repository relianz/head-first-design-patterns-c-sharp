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

using Advanced_WeatherStation.Implementations;

using static System.Console;

namespace Advanced_WeatherStation
{
    class WeatherStationConsole
    {
        static void Main(string[] args)
        {
            CurrentConditionsDisplay display_1, display_2;

            // Create Publisher:
            WeatherData weatherData = new WeatherData();

            // Create and register first observer:
            display_1 = new CurrentConditionsDisplay("First text display");
            display_1.Subscribe(weatherData);

            // Create and register first observer:
            display_2 = new CurrentConditionsDisplay("Second text display");
            display_2.Subscribe(weatherData);

            // Simulate availability of new measurements:
            weatherData.SetMeasurement(new Measurement(15.0f, 44.2f, 1020.0f));
            weatherData.SetMeasurement(new Measurement(16.5f, 48.9f, 1015.0f));
            weatherData.SetMeasurement(new Measurement(16.2f, 47.3f, 1025.0f));

            // Remove first observer from observable's notification list:            
            display_1.Unsubscribe();

            // Simulate availability of new measurements again:
            weatherData.SetMeasurement(new Measurement(18.0f, 50.0f, 980.0f));

            // Keap console open:
            ReadLine();

        } // Main

    } // class WeatherStationConsole

} // namespace Advanced_WeatherStation