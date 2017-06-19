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

using PizzaStoreWithAF.Pizzas;          // Pizza
using PizzaStoreWithAF.Ingredients;     // PizzaIngredientFactory
using static System.Console;            // WriteLine

namespace PizzaStoreWithAF.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza( string type )
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            
            if( type.Equals( "cheese" ) )
            {
                pizza = new CheesePizza( ingredientFactory );
                pizza.Name = "New York Style Cheese Pizza";

            } // cheese
            else
            {
                WriteLine( "{0}: Don't know how to create {1} pizza", this.GetType().ToString(), type );
                throw new System.NotImplementedException( type );

            } // unknown pizza type
            
            return pizza;

        } // PizzaStore.CreatePizza

    } // class NYPizzaStore

} // namespace  PizzaStoreWithAF.Stores
