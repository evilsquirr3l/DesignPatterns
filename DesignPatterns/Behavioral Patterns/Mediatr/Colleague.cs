namespace DesignPatterns.Behavioral_Patterns.Mediatr
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