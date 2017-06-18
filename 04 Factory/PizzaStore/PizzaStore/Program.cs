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

using PizzaStore.Pizzas;        // Pizza
using PizzaStore.Stores;        // NYPizzaStore, ChicagoPizzaStore
using static System.Console;

namespace PizzaStore
{
    public class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            PizzaStore.Stores.PizzaStore nyStore = new NYPizzaStore();
            PizzaStore.Stores.PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza;

            pizza = nyStore.OrderPizza( "cheese" );
            WriteLine( "Ethan ordered a {0} pizza\n", pizza.GetName() );

            pizza = chicagoStore.OrderPizza("cheese");
            WriteLine("Joel ordered a {0} pizza\n", pizza.GetName());

            // Keep console open:
            ReadLine();

        } // Main

    } // class PizzaTestDrive

} // namespace PizzaStore 
