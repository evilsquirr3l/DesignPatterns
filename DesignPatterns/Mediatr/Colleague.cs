namespace DesignPatterns.Mediatr
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