using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void Handle(int request)
        {
            Console.WriteLine("Do something2");
            
            Successor?.Handle(request);
        }
    }
}