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

using PizzaStoreWithAF.Ingredients;     // IPizzaIngredientFactory
using static System.Console;            // WriteLine

namespace PizzaStoreWithAF.Pizzas
{
    public class CheesePizza: Pizza
    {
        #region public
        public CheesePizza( IPizzaIngredientFactory ingredientFactory )
        {
            this.ingredientFactory = ingredientFactory;

        } // ctor

        public override void Prepare()
        {
            WriteLine( "Preparing {0} ", Name );

            dough  = ingredientFactory.CreateDough();
            sauce  = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();

        } // Pizza.Prepare
        #endregion

        #region private
        private IPizzaIngredientFactory ingredientFactory;
        #endregion

    } // class CheesePizza

} // namespace PizzaStoreWithAF.Pizzas
