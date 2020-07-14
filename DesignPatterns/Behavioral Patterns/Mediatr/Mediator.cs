namespace DesignPatterns.Behavioral_Patterns.Mediatr
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}