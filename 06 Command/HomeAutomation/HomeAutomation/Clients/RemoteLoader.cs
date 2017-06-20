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

using HomeAutomation.Invokers;      // RemoteControl
using HomeAutomation.Commands;      // LightOnCommand,...
using HomeAutomation.Receivers;     // Light,...


using static System.Console;        // WriteLine, ReadLine

namespace HomeAutomation.Clients
{ 
    class RemoteLoader
    {
        static void Main( string[] args )
        {
            int numberOfSlots = 7;

            // create command invoker:
            RemoteControl remoteControl = new RemoteControl( numberOfSlots );

            // create command receivers:
            Light livingRoomLight = new Light( "Living Room" );
            Light kitchenLight = new Light( "Kitchen" );
            CeilingFan ceilingFan = new CeilingFan( "LivingRoom" );

            // create living room light commands:
            LightOnCommand  livingRoomLightOn  = new LightOnCommand( livingRoomLight );
            LightOffCommand livingRoomLightOff = new LightOffCommand( livingRoomLight );

            // feed invoker with living room light commands:
            remoteControl.SetCommand( 0, livingRoomLightOn, livingRoomLightOff );

            // create living room ceiling fan commands:
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand( ceilingFan );
            CeilingFanOffCommand  ceilingFanOff  = new CeilingFanOffCommand( ceilingFan );

            // feed invoker with living room ceiling fan commands:
            remoteControl.SetCommand( 1, ceilingFanHigh, ceilingFanOff );            

            // feed invoker with kitchen light commands (using lambdas):
            remoteControl.SetCommand( 2, new Command( () => kitchenLight.On(), () => kitchenLight.Off() ), 
                                         new Command( () => kitchenLight.Off(), () => kitchenLight.On() ) );

            // show command settings:
            WriteLine( remoteControl );

            // simulate user behaviour:
            remoteControl.OnButtonWasPushed( 1 );
            remoteControl.OffButtonWasPushed( 1 );
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed( 2 );
            remoteControl.UndoButtonWasPushed();

            // keep console open:
            ReadLine();

        } // Main

    } // RemoteLoader

} // HomeAutomation.Clients
