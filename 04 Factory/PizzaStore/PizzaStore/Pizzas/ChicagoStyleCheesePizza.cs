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

using static System.Console;

namespace PizzaStore.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        #region public
        public ChicagoStyleCheesePizza()
        {
            name  = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add( "Shreded Mozzarella Cheese" );

        } // ctor
               
        public override void Cut()
        {
            WriteLine( "Cutting the pizza into square slices" );

        } // Cut        
        #endregion

    } // class ChicagoStyleCheesePizza

} // namespace PizzaStore.Pizzas
