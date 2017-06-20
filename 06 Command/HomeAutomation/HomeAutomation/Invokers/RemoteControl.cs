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

using System;                       // Type
using System.Text;                  // Stringbuilder
using static System.Console;        // WriteLine
using HomeAutomation.Commands;      // ICommand

namespace HomeAutomation.Invokers
{
    public class RemoteControl
    {
        #region public
        public RemoteControl( int numberOfSlots )
        {
            NumberOfSlots = numberOfSlots;

            onCommands  = new ICommand[ NumberOfSlots ];
            offCommands = new ICommand[ NumberOfSlots ];

            ICommand noCommand = new NoCommand();

            for ( int i = 0; i < NumberOfSlots; i++ )
            {
                onCommands[ i ]  = noCommand;
                offCommands[ i ] = noCommand;

            } // for all slots

            undoCommand = noCommand;

        } // ctor

        public void SetCommand( int slot, ICommand onCommand, ICommand offCommand )
        {
            if ( slot < 0 || slot >= NumberOfSlots )
            {
                string msg = "slot = " + slot;
                throw new System.ArgumentOutOfRangeException( msg );

            } // invalid slot

            #if DEBUG
            Type t;

            t = onCommands[ slot ].GetType();
            if ( !t.Equals( typeof( NoCommand ) ) )
                WriteLine( "Overwriting On Command <{0}> for slot <{1}>", t.ToString(), slot );
            
            t = offCommands[ slot ].GetType();
            if ( !t.Equals( typeof( NoCommand ) ) )
                WriteLine( "Overwriting Off Command <{0}> for slot <{1}>", t.ToString(), slot );
            #endif

            onCommands[ slot ] = onCommand;
            offCommands[ slot ] = offCommand;

        } // SetCommand

        public void OnButtonWasPushed( int slot )
        {
            onCommands[ slot ].Execute();
            undoCommand = onCommands[ slot ];

        } // OnButtonWasPushed

        public void OffButtonWasPushed(int slot)
        {
            offCommands[ slot ].Execute();
            undoCommand = offCommands[ slot ];

        } // OffButtonWasPushed

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();

        } // UndoButtonWasPushed

        public int NumberOfSlots
        {
            get => numberOfSlots;
            protected set => numberOfSlots = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append( "\n------ Remote Control ------\n" );
            
            for ( int i = 0; i < NumberOfSlots; i++ )
            {
                sb.Append( "[slot " + i + "] " + onCommands[ i ].GetType().Name );
                sb.Append( "    " + offCommands[ i ].GetType().Name + "\n" );

            } // for all slots

            return sb.ToString();

        } // ToString

        #endregion

        #region private
        private int numberOfSlots;

        private ICommand[] onCommands;
        private ICommand[] offCommands;

        private ICommand undoCommand;
        #endregion

    } // class RemoteControl

} // namespace HomeAutomation.Invokers
