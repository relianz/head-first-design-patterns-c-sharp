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

using System;                       // Action

namespace HomeAutomation.Commands
{
    public class Command : ICommand
    {
        #region public
        public Command( Action doAction, Action undoAction )
        {
            this.doAction = doAction;
            this.undoAction = undoAction;

        } // ctor
        
        public void Execute()
        {
            doAction();

        } // ICommand.Execute

        public void Undo()
        {
            undoAction();

        } // ICommand.Undo
        #endregion

        #region private
        private readonly Action doAction;
        private readonly Action undoAction;
        #endregion

    } // class Command

} // namespace HomeAutomation.Commands
