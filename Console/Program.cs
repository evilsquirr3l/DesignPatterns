using System;
using DesignPatterns.Command;
using DesignPatterns.Command.Undo;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document {Content = "Hello world"};

            var history = new History();
            var boldCommand = new BoldCommand(history, document);
            boldCommand.Execute();

            System.Console.WriteLine(document.Content);
            
            boldCommand.Unexecute();
            System.Console.WriteLine(document.Content);
        }
    }
}