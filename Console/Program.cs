using System;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Command.Undo;
using DesignPatterns.Mediatr;
using DesignPatterns.Observer;
using DesignPatterns.Visitor;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            
            document.Execute(new ConcreteOperation());
        }
    }
}