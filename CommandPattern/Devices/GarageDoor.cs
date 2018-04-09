using System;

namespace CommandPattern.Devices
{
    public class GarageDoor
    {
        public void DoorUp()
        {
            Console.WriteLine("Master is back, let the car in.");
        }

        public void DoorDown()
        {
            Console.WriteLine("Close the garage door.");
        }
    }
}
