namespace DesignPatterns.Behavioral_Patterns.Command.Undo
{
    public interface IUndoableCommand : Command.ICommand
    {
        void Unexecute();
    }
}