namespace Design.Pattern.Behavioral.Command.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
