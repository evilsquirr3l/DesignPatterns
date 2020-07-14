namespace DesignPatterns.Behavioral_Patterns.Command.Undo
{
    public class UndoCommand : Command.ICommand
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            _history.Dequeue().Unexecute(); 
        }
    }
}