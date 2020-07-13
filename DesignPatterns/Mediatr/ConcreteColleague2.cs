using System;

namespace DesignPatterns.Mediatr
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
            
        }

        public void Send(string message)
        {
            Mediator.Send(message + ", send from colleague1", this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}