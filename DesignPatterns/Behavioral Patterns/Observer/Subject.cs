using System.Collections.Generic;

namespace DesignPatterns.Behavioral_Patterns.Observer
{
    public abstract class Subject
    {
        private ICollection<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}