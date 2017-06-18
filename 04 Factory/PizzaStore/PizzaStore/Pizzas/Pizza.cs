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

using System.Collections.Generic;
using System;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {        
        #region public
        public void Prepare()
        {
            Console.WriteLine( "Preparing {0}", name );
            Console.WriteLine( "Tossing dough..." );
            Console.WriteLine( "Adding sauce..." );
            Console.WriteLine( "Adding toppings:");

            foreach (var t in toppings)
                Console.WriteLine( "   {0}", t );

        } // Prepare

        public string GetName()
        {
            return name;
        }
                
        public virtual void Bake()
        {
            Console.WriteLine( "Bake for 25 Minutes at 350°" );

        } // Bake

        public virtual void Cut()
        {
            Console.WriteLine( "Cutting the pizza into diagonal slices" );

        } // Cut

        public virtual void Box()
        {
            Console.WriteLine( "Place pizza in official PizzaStore box" );

        } // Box        
        #endregion public

        #region protected
        protected string name;
        protected string dough;
        protected string sauce;

        protected List<string> toppings = new List<string>();
        #endregion

    } // class Pizza

} // namespace PizzaStore.Pizzas 
