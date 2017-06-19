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

namespace PizzaStoreWithAF.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();

        } // IPizzaIngredientFactory.CreateCheese

        public IClams CreateClam()
        {
            return new FrozenClams();

        } // IPizzaIngredientFactory.CreateClam

        public IDough CreateDough()
        {
            return new ThickCrustDough();

        } // IPizzaIngredientFactory.CreateDough

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();

        } // IPizzaIngredientFactory.CreatePepperoni

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();

        } // IPizzaIngredientFactory.CreateSauce

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Spinach(), new BlackOlives(), new EggPlant() };

            return veggies;

        } // IPizzaIngredientFactory.CreateVeggies

    } // class ChicagoPizzaIngredientFactory

} // namespace PizzaStoreWithAF.Ingredients
