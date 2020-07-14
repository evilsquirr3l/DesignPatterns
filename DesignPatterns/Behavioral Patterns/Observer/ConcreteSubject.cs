using System;

namespace DesignPatterns.Behavioral_Patterns.Observer
{
    public class ConcreteSubject : Subject
    {
        private string _data;
        public string Data
        {
            get => _data;
            set
            {
                _data = value;
                Notify();
            }
        }

        public void SomeMethod()
        {
            Console.WriteLine(Data);
            Notify();
        }
    }
}