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

using Starbuzz.Beverages;       // class Beverage

namespace Starbuzz.Decorators
{
    public class Mocha: CondimentDecorator
    {
        public Mocha( Beverage beverage )
        {
            this.beverage = beverage;

        } // ctor.

        #region overrides
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";

        } // CondimentDecorator.GetDescription

        public override double Cost()
        {
            return beverage.Cost() + .20;

        } // Beverage.Cost
        #endregion

    } // class Mocha.

} // namespace Starbuzz.Decorators
