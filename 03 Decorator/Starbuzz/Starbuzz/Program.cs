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

using static System.Console;

using Starbuzz.Beverages;       // Beverage, Espresso,...
using Starbuzz.Decorators;      // Mocha, Whip,...

namespace Starbuzz
{
    class StarbuzzCoffee
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();
            WriteLine("{0} ${1}", beverage1.GetDescription(), beverage1.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            WriteLine("{0} ${1}", beverage2.GetDescription(), beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            WriteLine("{0} ${1}", beverage3.GetDescription(), beverage3.Cost());

            ReadLine();

        } // Main

    } // class StarbuzzCoffee

} // namespace Starbuzz
