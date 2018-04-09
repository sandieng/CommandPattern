using System;

namespace CommandPattern.Devices
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Let there be light!");
        }

        public void Off()
        {
            Console.WriteLine("Darkness hovers in the void of the universe!");
        }
    }
}
