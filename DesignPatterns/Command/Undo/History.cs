using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Command.Undo
{
    public class History
    {
        private Queue<IUndoableCommand> _commands = new Queue<IUndoableCommand>();

        public void Enqueue(IUndoableCommand command)
        {
            _commands.Enqueue(command);
        }

        public IUndoableCommand Dequeue()
        {
            return _commands.Dequeue();
        }
    }
}