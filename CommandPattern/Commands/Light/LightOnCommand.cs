namespace CommandPattern.Commands.Light
{
    public class LightOnCommand: ICommand
    {
        private readonly Devices.Light _light;

        public LightOnCommand(Devices.Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}
