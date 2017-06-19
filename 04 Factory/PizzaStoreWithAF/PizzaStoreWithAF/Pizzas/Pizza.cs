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

using System.Text;                      // StringBuilder
using static System.Console;            // WriteLine
using PizzaStoreWithAF.Ingredients;     // IDough, ISauce,...

namespace PizzaStoreWithAF.Pizzas
{
    public abstract class Pizza
    {
        #region public
        public abstract void Prepare();

        public string Name
        {
            get => name;
            set => name = value;

        } // Name

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append( "---- Ingredients of " + Name + " ----\n" );
            if( dough != null )
            {
                result.Append( dough );
                result.Append( "\n" );
            }
            if( sauce != null )
            {
                result.Append( sauce );
                result.Append( "\n" );
            }
            if( cheese != null )
            {
                result.Append( cheese );
                result.Append( "\n" );
            }
            if( veggies != null )
            {
                for( int i = 0; i < veggies.Length; i++ )
                {
                    result.Append( veggies[ i ] );
                    if( i < veggies.Length - 1 )
                    {
                        result.Append( ", " );
                    }
                }
                result.Append( "\n" );
            }
            if( clam != null )
            {
                result.Append( clam );
                result.Append( "\n" );
            }
            if( pepperoni != null )
            {
                result.Append( pepperoni );
                result.Append( "\n" );
            }
            return result.ToString();

        } // ToString

        public virtual void Bake()
        {
            WriteLine("Bake for 25 Minutes at 350°");

        } // Bake

        public virtual void Cut()
        {
            WriteLine("Cutting the pizza into diagonal slices");

        } // Cut

        public virtual void Box()
        {
            WriteLine("Place pizza in official PizzaStore box");

        } // Box        
        #endregion public

        #region protected
        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies[] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clam;
        #endregion

        #region private
        private string name;
        #endregion

    } // class Pizza

} // namespace PizzaStoreWithAF.Pizzas
