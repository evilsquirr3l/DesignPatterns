using System;
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
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            
            colleague1.Send("Hi");
            mediator.Send("Hi too", colleague1);
        }
    }
}