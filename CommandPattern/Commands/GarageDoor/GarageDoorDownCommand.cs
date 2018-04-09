namespace CommandPattern.Commands.GarageDoor
{
    public class GarageDoorDownCommand : ICommand
    {
        private readonly Devices.GarageDoor _garageDoor;

        public GarageDoorDownCommand(Devices.GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.DoorDown();
        }
    }
}
