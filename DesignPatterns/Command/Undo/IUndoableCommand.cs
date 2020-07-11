namespace DesignPatterns.Command.Undo
{
    public interface IUndoableCommand : Command.ICommand
    {
        void Unexecute();
    }
}