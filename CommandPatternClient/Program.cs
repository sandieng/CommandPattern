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
            var remote = new RemoteController();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            remote.SetCommand(lightOn);
            remote.ActivateCommand();
            remote.SetCommand(lightOff);
            remote.ActivateCommand();

            // Control the garage door
            var garageDoor = new GarageDoor();
            var doorUp = new GarageDoorUpCommand(garageDoor);
            var doorDown = new GarageDoorDownCommand(garageDoor);

            remote.SetCommand(doorUp);
            remote.ActivateCommand();
            remote.SetCommand(doorDown);
            remote.ActivateCommand();

            Console.ReadKey();
        }
    }
}
