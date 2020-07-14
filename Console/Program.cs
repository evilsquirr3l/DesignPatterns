using System;
using DesignPatterns.Behavioral_Patterns.Visitor;

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