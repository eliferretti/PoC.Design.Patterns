using Design.Pattern.Behavioral.Command.Devices;

namespace Design.Pattern.Behavioral.Command.Commands
{
    public class FanOnCommand : ICommand
    {
        private Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.On();
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}
