using CommandPattern;
using CommandPattern.Commands.Light;
using CommandPattern.Devices;
using System;
using CommandPattern.Commands.GarageDoor;

namespace CommandPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control the light
            var remote = new RemoteController();        // Invoker
            var light = new Light();                    // Receiver
            var lightOn = new LightOnCommand(light);    // Command
            var lightOff = new LightOffCommand(light);  // Command

            remote.SetCommand(lightOn);
            remote.ActivateCommand();
            remote.SetCommand(lightOff);
            remote.ActivateCommand();

            // Control the garage door
            var garageDoor = new GarageDoor();                      // Receiver
            var doorUp = new GarageDoorUpCommand(garageDoor);       // Command
            var doorDown = new GarageDoorDownCommand(garageDoor);   // Command

            // Invoker ---> Command ----> Receiver
            remote.SetCommand(doorUp);
            remote.ActivateCommand();
            remote.SetCommand(doorDown);
            remote.ActivateCommand();

            Console.ReadKey();
        }
    }
}
