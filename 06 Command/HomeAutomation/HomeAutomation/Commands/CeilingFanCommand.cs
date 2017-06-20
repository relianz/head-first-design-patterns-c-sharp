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

using HomeAutomation.Receivers;         // CeilingFan
using static System.Console;            // WriteLine

namespace HomeAutomation.Commands
{
    public class CeilingFanCommand
    {
        #region public
        public CeilingFanCommand( CeilingFan ceilingFan )
        {
            this.ceilingFan = ceilingFan;

        } // ctor

        public void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFan.Speeds.HIGH:
                    ceilingFan.High();
                    break;

                case CeilingFan.Speeds.MEDIUM:
                    ceilingFan.Medium();
                    break;

                case CeilingFan.Speeds.LOW:
                    ceilingFan.Low();
                    break;

                case CeilingFan.Speeds.OFF:
                    ceilingFan.Off();
                    break;

                default:
                    WriteLine( "Value of previous speed aut of range: <{0}>", prevSpeed );
                    throw new System.NotImplementedException( "prevSpeed" );

            } // switch prevSpeed

        } // Undo
        #endregion

        #region protected 
        protected CeilingFan ceilingFan;
        protected CeilingFan.Speeds prevSpeed;
        #endregion

    } // class CeilingFanCommand

} // namespace HomeAutomation.Commands
