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

using PizzaStoreWithAF.Pizzas;      // Pizza
using PizzaStoreWithAF.Stores;      // PizzaStore,...
using static System.Console;        // WriteLine,...

namespace PizzaStoreWithAF
{
    public class PizzaTestDrive
    {
        public static void Main( string[] args )
        {
            PizzaStoreWithAF.Stores.PizzaStore nyStore = new NYPizzaStore();
            PizzaStoreWithAF.Stores.PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza;

            pizza = nyStore.OrderPizza( "cheese" );
            WriteLine( "Ethan ordered a {0} pizza\n", pizza.Name );
            WriteLine( pizza );

            pizza = chicagoStore.OrderPizza( "cheese" );
            WriteLine( "Joel ordered a {0} pizza\n", pizza.Name );
            WriteLine( pizza );

            // Keep console open:
            ReadLine();

        } // Main

    } // class PizzaTestDrive

} // namespace PizzaStoreWithAF
