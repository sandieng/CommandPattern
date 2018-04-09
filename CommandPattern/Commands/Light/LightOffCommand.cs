namespace CommandPattern.Commands.Light
{
    public class LightOffCommand : ICommand
    {
        private readonly Devices.Light _light;

        public LightOffCommand(Devices.Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
