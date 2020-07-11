using System;
using DesignPatterns.Command;
using DesignPatterns.Command.Undo;
using DesignPatterns.Observer;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteSubject = new ConcreteSubject();
            
            var obs1 = new ConcreteObserver1(concreteSubject);
            var obs2 = new ConcreteObserver2(concreteSubject);
            
            concreteSubject.Attach(obs1);
            concreteSubject.Attach(obs2);
            
            concreteSubject.Data = "Kek";
        }
    }
}