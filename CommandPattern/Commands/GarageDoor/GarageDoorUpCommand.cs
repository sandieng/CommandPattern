namespace CommandPattern.Commands.GarageDoor
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly Devices.GarageDoor _garageDoor;

        public GarageDoorUpCommand(Devices.GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.DoorUp();
        }
    }
}
