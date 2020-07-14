using System.Collections.Generic;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class CompositeCommand : ICommand
    {
        private ICollection<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }
        
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}