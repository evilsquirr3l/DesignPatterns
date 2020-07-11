using System;

namespace DesignPatterns.Observer
{
    public class ConcreteObserver1 : IObserver
    {
        private ConcreteSubject _subject;

        public ConcreteObserver1(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"ConcreteObserver1 notified with data {_subject.Data}");
        }
    }
}