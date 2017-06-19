//
//    Head First Design Patterns - C# Examples (HFDP/C#)
//
//    Copyright (C) 2017 Markus A. Stulle (markus@stulle.zone)
//
//    This file is part of HFDP/C#.   
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

using static System.Console;    // WriteLine, ReadLine
using System.Threading;         // Thread

namespace Hershey
{
    class Program
    {
        static void RunBoiler( ChocolateBoiler boiler )
        {            
            while (true)
            {
                boiler.Fill();
                Thread.Sleep( 1000 );

                boiler.Boil();
                Thread.Sleep( 3000 );

                boiler.Drain();
                Thread.Sleep( 1000 );

            } // forever

        } // RunBoiler

        static void CheckBoiler( ChocolateBoiler boiler )
        {
            while (true)
            {
                int t = boiler.GetTemperature();
                WriteLine( "Temperature of boiler <{0}> is {1}°", boiler.Name, t );
                Thread.Sleep( 500 );
                
            } // forever

        } // RunBoiler

        static void Main( string[] args )
        {
            ChocolateBoiler b;

            // Create the one and only boiler instance: 
            b = ChocolateBoiler.GetInstance( "Hershey-1" );

            // Create and start temperature monitoring thread:
            Thread t1 = new Thread( () => CheckBoiler( b ) );
            t1.Start();

            // Create and start process controlling thread (on boiler singleton): 
            b = ChocolateBoiler.GetInstance();
            Thread t2 = new Thread( () => RunBoiler( b ) );
            t2.Start();

            // Keep console open:
            ReadLine();

        } // Main.

    } // class Program

} // namespace Hershey
