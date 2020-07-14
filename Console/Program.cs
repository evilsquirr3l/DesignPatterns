using System;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Command.Undo;
using DesignPatterns.Mediatr;
using DesignPatterns.Observer;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            
            handler1.SetSuccessor(handler2);
            handler1.Handle(1);
        }
    }
}