using Design.Pattern.Behavioral.Command.Devices;

namespace Design.Pattern.Behavioral.Command.Commands
{
    public class FanOffCommand : ICommand
    {
        private Fan _fan;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.Off();
        }

        public void Undo()
        {
            _fan.On();
        }
    }
}
