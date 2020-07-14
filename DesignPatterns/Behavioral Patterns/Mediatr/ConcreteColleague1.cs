using System;

namespace DesignPatterns.Behavioral_Patterns.Mediatr
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
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