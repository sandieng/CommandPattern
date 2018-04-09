namespace CommandPattern
{
    public class RemoteController
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ActivateCommand()
        {
            _command.Execute();
        }
    }
}
