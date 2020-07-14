using System;

namespace DesignPatterns.Behavioral_Patterns.Observer
{
    public class ConcreteObserver2 : IObserver
    {
        private ConcreteSubject _subject;

        public ConcreteObserver2(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"ConcreteObserver2 notified with data {_subject.Data}");
        }
    }
}