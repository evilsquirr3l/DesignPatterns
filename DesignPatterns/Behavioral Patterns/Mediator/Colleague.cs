namespace DesignPatterns.Behavioral_Patterns.Mediator
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        public Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}