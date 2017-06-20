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

using System;                       // Boolean
using static System.Console;        // WriteLine

namespace Hershey
{
    public class ChocolateBoiler
    {
        #region public

        public static ChocolateBoiler GetInstance( string name )
        {
            // use double-checked locking to ensure thread safety:
            if ( uniqueInstance == null )
            {                
                Object lockThis = new Object();
                lock ( lockThis )
                {
                    uniqueInstance = new ChocolateBoiler();

                    if( name != null )
                        uniqueInstance.name = name;

                    uniqueInstance.IsEmpty = true;

                } // lock

            } // first instance 

            return uniqueInstance;

        } // ctor

        public static ChocolateBoiler GetInstance()
        {
            return GetInstance( null );
        
        } // ctor

        public void Fill()
        {
            if( IsEmpty )
            {
                WriteLine( "Filling boiler <{0}> with milk/chocolate mixture", Name );

                IsEmpty  = false;
                IsBoiled = false;

            } // IsEmpty

        } // Fill

        public void Boil()
        {
            if( !IsEmpty && !IsBoiled )
            {
                WriteLine( "Bringing the contents of boiler <{0}> to a boil", Name );

                IsBoiled = true;

            } // Ready to boil

        } // Boil

        public void Drain()
        {
            if( !IsEmpty && IsBoiled )
            {
                WriteLine( "Drained the boiled milk and chocolate from boiler <{0}>", Name );

                IsEmpty = true;

            } // IsEmpty

        } // Fill

        public int GetTemperature()
        {
            if( IsEmpty )
            {
                return 30;
            }
            else
            if( !IsEmpty && !IsBoiled )
            {
                return 15;
            }
            else
            if( !IsEmpty && IsBoiled )
            {
                return 55;
            }
            else
            {
                // TODO: throw private exeception.
                return -1;
            }
            
        } // GetTemperature

        public string Name { get => name; }
        public bool IsEmpty { get => isEmpty; protected set => isEmpty = value; }
        public bool IsBoiled { get => isBoiled; protected set => isBoiled = value; }
        #endregion

        #region private
        private static ChocolateBoiler uniqueInstance;
        private ChocolateBoiler() {

        } // ctor

        private string name;
        private Boolean isEmpty;
        private Boolean isBoiled;
        #endregion

    } // class ChocolateBoiler

} // namespace Hershey
