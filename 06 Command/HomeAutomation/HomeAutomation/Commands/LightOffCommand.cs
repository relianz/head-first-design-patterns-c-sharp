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

using HomeAutomation.Receivers;         // Light

namespace HomeAutomation.Commands
{
    public class LightOffCommand : ICommand
    {
        #region public
        public LightOffCommand( Light light )
        {
            this.light = light;

        } // ctor

        public void Execute()
        {
            light.Off();

        } // ICommand.Execute

        public void Undo()
        {
            light.On();

        } // Undo
        #endregion

        #region private
        private Light light;
        #endregion

    } // class LightOffCommand

} // namespace HomeAutomation.Commands
