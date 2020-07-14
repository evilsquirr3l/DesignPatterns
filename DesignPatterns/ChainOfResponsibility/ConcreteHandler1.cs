using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ConcreteHandler1  : Handler
    { 
        public override void Handle(int request)
        {
            Console.WriteLine("Do something");

            Successor?.Handle(request);
        }
    }
}