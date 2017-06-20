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

namespace HomeAutomation.Receivers
{
    public class CeilingFan
    {
        #region public
        public CeilingFan( string location )
        {
            Location = location;
            Speed = Speeds.OFF;

        } // ctor

        public void High()
        {
            Speed = Speeds.HIGH;
            ShowSpeed();

        } // High

        public void Medium()
        {
            Speed = Speeds.MEDIUM;
            ShowSpeed();

        } // Medium

        public void Low()
        {
            Speed = Speeds.LOW;
            ShowSpeed();

        } // Low

        public void Off()
        {
            Speed = Speeds.OFF;
            ShowSpeed();

        } // Off

        public void ShowSpeed()
        {
            WriteLine( "Speed of fan in <{0}> is <{1}>", Location, Speed.ToString() );

        } // ShowSpeed

        public enum Speeds : byte { HIGH = 3, MEDIUM = 2, LOW = 1, OFF = 0 };

        public string Location { get => location; protected set => location = value; }
        public Speeds Speed { get => speed; protected set => speed = value; }
        #endregion

        #region private
        private string location;
        private Speeds speed;
        #endregion

    } // class CeilingFan

} // namespace HomeAutomation.Receivers
